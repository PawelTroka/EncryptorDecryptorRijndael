using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace EncryptorDecryptorRijndael.Encrypt
{
    sealed internal class Encryptor : BaseEncrypt
    {
        public Encryptor(string inputFile, string outputFile, int Keylength, int blockSize, string mode, string password, int feedbackSize = 8)
            : base(inputFile, outputFile, password)
        {
            this.cipherRijndael.BlockSize = blockSize;
            this.cipherRijndael.FeedbackSize = feedbackSize;
            this.cipherRijndael.KeySize = Keylength;
            this.cipherRijndael.Mode = (CipherMode)Enum.Parse(typeof(CipherMode), mode);

            this.cipherRijndael.GenerateIV();
            this.cipherRijndael.GenerateKey();
        }

        public void encrypt(object s, System.ComponentModel.DoWorkEventArgs e)
        {
            System.ComponentModel.BackgroundWorker worker = s as System.ComponentModel.BackgroundWorker;
            loadData();
            worker.ReportProgress(10);//+10%
            if (worker.CancellationPending) { e.Cancel = true; return; }


            byte[] headerText = generateHeaderText();
            worker.ReportProgress(30);//+20%
            if (worker.CancellationPending) { e.Cancel = true; return; }

            byte[] cipherText = generateCipherText(s, e);
            worker.ReportProgress(80);//+50%
            if (worker.CancellationPending) { e.Cancel = true; return; }

            byte[] headerAndCipherText = new byte[headerText.Length + cipherText.Length];
            headerText.CopyTo(headerAndCipherText, 0);
            cipherText.CopyTo(headerAndCipherText, headerText.Length);
            encryptedData = headerAndCipherText;
            worker.ReportProgress(90);//+10%
            if (worker.CancellationPending) { e.Cancel = true; return; }

            saveData();
            worker.ReportProgress(100); //+10%

        }

        private byte[] generateHeaderText()
        {
            string sb = "";

            sb += ("<EncryptedFileHeader>" + Environment.NewLine);
            sb += ("<Algorithm>" + "Rijndael" + "</Algorithm>" + Environment.NewLine);
            sb += ("<CipherMode>" + cipherRijndael.Mode + "</CipherMode>" + Environment.NewLine);
            sb += ("<BlockSize>" + cipherRijndael.BlockSize + "</BlockSize>" + Environment.NewLine);
            sb += ("<FeedbackSize>" + cipherRijndael.FeedbackSize + "</FeedbackSize>" + Environment.NewLine);
            sb += ("<KeySize>" + cipherRijndael.KeySize + "</KeySize>" + Environment.NewLine);
            sb += ("<EncryptedKey>" + byteArrayToString(generateEncryptedKey(cipherRijndael.Key)) + "</EncryptedKey>" + Environment.NewLine);
            sb += ("<IV>" + byteArrayToString(cipherRijndael.IV) + "</IV>" + Environment.NewLine);
            sb += ("</EncryptedFileHeader>");

            return Encoding.ASCII.GetBytes(sb.ToString());
        }

        private byte[] generateEncryptedKey(byte[]  key)
        {
            using (var encryptor = this.encryptedKeyRijndael.CreateEncryptor())
            using (MemoryStream msEncrypt = new MemoryStream())
            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            {
                using (BinaryWriter bwEncrypt = new BinaryWriter(csEncrypt))
                {
                    bwEncrypt.Write(key);
                }
                return msEncrypt.ToArray();
            }
        }

        private string byteArrayToString(byte[] source)
        {
            var sb = new StringBuilder();
            foreach (var b in source)
            { sb.Append(b); sb.Append('.'); }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        protected override void loadData()
        {
            dataToEncrypt = File.ReadAllBytes(inputFilePath);
        }

        protected override void saveData()
        {
            File.WriteAllBytes(outputFilePath, encryptedData);
        }


        private byte[] generateCipherText(object s, System.ComponentModel.DoWorkEventArgs e)
        {
            System.ComponentModel.BackgroundWorker worker = s as System.ComponentModel.BackgroundWorker;
            using (var encryptor = this.cipherRijndael.CreateEncryptor())
            using (MemoryStream msEncrypt = new MemoryStream())
            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            {
                worker.ReportProgress(35);
                using (BinaryWriter bwEncrypt = new BinaryWriter(csEncrypt))
                {
                    worker.ReportProgress(40);
                    bwEncrypt.Write(dataToEncrypt);
                    worker.ReportProgress(70);
                }
                return msEncrypt.ToArray();
            }
        }

        private byte[] dataToEncrypt;
    }
}
