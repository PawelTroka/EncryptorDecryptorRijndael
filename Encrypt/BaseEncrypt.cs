using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace EncryptorDecryptorRijndael.Encrypt
{
    internal abstract class BaseEncrypt
    {
        public BaseEncrypt(string inputFilePath, string outputFilePath, string password)
        {
            if (!File.Exists(inputFilePath))
                throw new ArgumentException("Input file does not exists!");

            this.inputFilePath = inputFilePath; this.outputFilePath = outputFilePath;
            this.cipherRijndael = new RijndaelManaged();
            this.cipherRijndael.Padding = PaddingMode.Zeros;

            this.encryptedKeyRijndael = new RijndaelManaged();
            this.encryptedKeyRijndael.Mode = CipherMode.ECB;
            this.encryptedKeyRijndael.Padding = PaddingMode.Zeros;
            this.encryptedKeyRijndael.BlockSize = 256;
            generateHash(password);
            this.encryptedKeyRijndael.Key = passwordHashed;
        }


        public static bool validatePassword(string pass, string repass)
        {
            if (pass == null || pass == "" || pass.Length < 7)
            {

                MessageBox.Show("Your password is too short or empty, please change it!", "Error");
                return false;
            }

            if (pass != repass)
            {
                MessageBox.Show("Your passwords dont match, please change it!", "Error");
                return false;
            }

            if (Encoding.UTF8.GetByteCount(pass) == pass.Length)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Your password contains non-ASCII characters, please change it!", "Error");
                return false;
            }
        }

        private void generateHash(string pass)
        {
            using (var hash = new SHA256Managed())
            {
                passwordHashed = hash.ComputeHash(Encoding.ASCII.GetBytes(pass));
            }
        }

        protected abstract void loadData();
        protected abstract void saveData();

        protected internal byte[] passwordHashed;

        protected string inputFilePath, outputFilePath;
        protected internal byte[] encryptedData;
        protected internal RijndaelManaged cipherRijndael;
        protected internal readonly RijndaelManaged encryptedKeyRijndael;
        //protected const byte[] 
    }
}
