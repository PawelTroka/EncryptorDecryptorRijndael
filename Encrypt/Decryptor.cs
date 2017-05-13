using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace EncryptorDecryptorRijndael.Encrypt
{
    sealed internal class Decryptor : BaseEncrypt
    {
        public Decryptor(string inputFile, string outputFile, string password)
            : base(inputFile, outputFile, password)
        {
        }

        public void decrypt(object s, System.ComponentModel.DoWorkEventArgs e)
        {
            System.ComponentModel.BackgroundWorker worker = s as System.ComponentModel.BackgroundWorker;
            loadData();
            worker.ReportProgress(10);
            if (worker.CancellationPending) { e.Cancel = true; return; }

            byte[] header, cipherText;
            splitDataIntoHeaderAndCiphertext(out header, out cipherText);
            worker.ReportProgress(25);
            if (worker.CancellationPending) { e.Cancel = true; return; }

            parseHeader(header);
            worker.ReportProgress(40);
            if (worker.CancellationPending) { e.Cancel = true; return; }

            encryptedData = cipherText;
            decryptCipherText(s, e);
            worker.ReportProgress(90);
            if (worker.CancellationPending) { e.Cancel = true; return; }

            saveData();
            worker.ReportProgress(100);
        }

        private void decryptCipherText(object s, System.ComponentModel.DoWorkEventArgs e)
        {
            System.ComponentModel.BackgroundWorker worker = s as System.ComponentModel.BackgroundWorker;
            ICryptoTransform decryptor = cipherRijndael.CreateDecryptor();

            // Create the streams used for decryption.
            using (MemoryStream msDecrypt = new MemoryStream(encryptedData))
            {
                worker.ReportProgress(60);
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    worker.ReportProgress(65);

                    using (BinaryReader srDecrypt = new BinaryReader(csDecrypt))
                    {
                        worker.ReportProgress(70);
                        decryptedData = srDecrypt.ReadAllBytes();
                        //csDecrypt.FlushFinalBlock();

                        worker.ReportProgress(90);
                    }
                }
            }
        }

        private void parseHeader(byte[] header)
        {
            string str = Encoding.ASCII.GetString(header);

            int start, end;
            start = str.IndexOf("<IV>") + "<IV>".Length;
            end = str.IndexOf("</IV>") - 1;
            string iv = (str.Substring(start, end - start + 1));

            start = str.IndexOf("<EncryptedKey>") + "<EncryptedKey>".Length;
            end = str.IndexOf("</EncryptedKey>") - 1;
            string encryptedKey = (str.Substring(start, end - start + 1));


            start = str.IndexOf("<BlockSize>") + "<BlockSize>".Length;
            end = str.IndexOf("</BlockSize>") - 1;
            string blocksize = (str.Substring(start, end - start + 1));

            start = str.IndexOf("<FeedbackSize>") + "<FeedbackSize>".Length;
            end = str.IndexOf("</FeedbackSize>") - 1;
            string feedbacksize = (str.Substring(start, end - start + 1));

            start = str.IndexOf("<CipherMode>") + "<CipherMode>".Length;
            end = str.IndexOf("</CipherMode>") - 1;
            string mode = (str.Substring(start, end - start + 1));

            start = str.IndexOf("<KeySize>") + "<KeySize>".Length;
            end = str.IndexOf("</KeySize>") - 1;
            string keySize = (str.Substring(start, end - start + 1));

            cipherRijndael.Mode = (CipherMode)Enum.Parse(typeof(CipherMode), mode);
            cipherRijndael.FeedbackSize = int.Parse(feedbacksize);
            cipherRijndael.BlockSize = int.Parse(blocksize);
            cipherRijndael.KeySize = int.Parse(keySize);
            cipherRijndael.IV = stringToByteArray(iv);
            var key = decryptEncryptedKey(stringToByteArray(encryptedKey));
            cipherRijndael.Key = key;
        }

        private byte[] decryptEncryptedKey(byte[] encryptedKey)
        {
            ICryptoTransform decryptor = encryptedKeyRijndael.CreateDecryptor();
            byte[] decryptedKey;
            // Create the streams used for decryption.
            using (MemoryStream msDecrypt = new MemoryStream(encryptedKey))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (BinaryReader srDecrypt = new BinaryReader(csDecrypt))
                    {
                        decryptedKey = srDecrypt.ReadAllBytes();
                    }
                }
            }
            return decryptedKey;
        }

        private byte[] stringToByteArray(string source)
        {
            string[] strings = source.Split('.');
            byte[] bytes = new byte[strings.Length];

            for (int i = 0; i < strings.Length; i++)
                bytes[i] = byte.Parse(strings[i]);
            return bytes;
        }

        private void splitDataIntoHeaderAndCiphertext(out byte[] header, out byte[] cipherText)
        {
           int first = 0, last = 0;
           /* for (int i = 0; i < encryptedData.Length; i++)
            {
                if (encryptedData[i] == '<' && encryptedData[i + 1] == 'h' && encryptedData[i + 2] == 'e' && encryptedData[i + 3] == 'a' && encryptedData[i + 4] == 'd')
                {
                    first = i;
                }
                else if (encryptedData[i] == '<' && encryptedData[i + 1] == '/' && encryptedData[i + 2] == 'h' && encryptedData[i + 3] == 'e' && encryptedData[i + 4] == 'a' && encryptedData[i + 5] == 'd')
                {
                    last = i + 8;
                    break;
                }
                if (i > encryptedData.Length - 9)
                    throw new Exception("Encrypted file is corrupted or not compatible, cannot decrypt");
            }*/
           first = encryptedData.Locate(Encoding.ASCII.GetBytes("<EncryptedFileHeader>"));
           last = encryptedData.Locate(Encoding.ASCII.GetBytes("</EncryptedFileHeader>")) + "</EncryptedFileHeader>".Length-1;

           if (first==-1 || last==-1)
               throw new Exception("Encrypted file is corrupted or not compatible, cannot decrypt");

            header = new byte[last - first + 1];
            cipherText = new byte[encryptedData.Length - last - 1];
            Array.Copy(encryptedData, first, header, 0, last - first + 1);
            var strtr = Encoding.ASCII.GetString(header);
            //System.Windows.Forms.MessageBox.Show(Encoding.ASCII.GetString(header));
            Array.Copy(encryptedData, last + 1, cipherText, 0, encryptedData.Length - last - 1);

            // System.Windows.Forms.MessageBox.Show(Encoding.ASCII.GetString(header));
        }

        protected override void loadData()
        {
            encryptedData = File.ReadAllBytes(inputFilePath);
        }

        protected override void saveData()
        {
            File.WriteAllBytes(outputFilePath, decryptedData);
        }

        private byte[] decryptedData;
    }




    public static class ByteArrayExtension
    {
        static readonly int[] Empty = new int[0];

        public static int Locate(this byte[] self, byte[] candidate)
        {
            if (IsEmptyLocate(self, candidate))
                return -1;

            for (int i = 0; i < self.Length; i++)
            {
                if (!IsMatch(self, i, candidate))
                    continue;

                return i;
            }

            return -1;
        }

        static bool IsMatch(byte[] array, int position, byte[] candidate)
        {
            if (candidate.Length > (array.Length - position))
                return false;

            for (int i = 0; i < candidate.Length; i++)
                if (array[position + i] != candidate[i])
                    return false;

            return true;
        }

        static bool IsEmptyLocate(byte[] array, byte[] candidate)
        {
            return array == null
                || candidate == null
                || array.Length == 0
                || candidate.Length == 0
                || candidate.Length > array.Length;
        }
    }


    public static class BinaryReaderExtension
    {
        public static byte[] ReadAllBytes(this BinaryReader reader)
        {
            const int bufferSize = 4096;
            using (var ms = new MemoryStream())
            {
                byte[] buffer = new byte[bufferSize];
                int count;
                while ((count = reader.Read(buffer, 0, buffer.Length)) != 0)
                    ms.Write(buffer, 0, count);
                return ms.ToArray();
            }

        }
    }
}
