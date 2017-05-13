using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace EncryptorDecryptorRijndael.Utils
{
    class PasswordGenerator
    {
        public PasswordGenerator()
        {
            random = new RNGCryptoServiceProvider();
            weakRandom = new Random();
        }

        public string generatePassword(int characters)
        {
            char[] str=new char[characters];

            for (int i = 0; i < str.Length; i++)
                str[i] = (char)generateChar();

                return (new string(str));
        }
        //33 to 126

        private byte generateChar()
        {
            byte[] data = new byte[5];
            while (true)
            {
                random.GetBytes(data);
                foreach (var b in data)
                    if (b >= 33 && b <= 126)
                        return b;
            }
        }

        private RNGCryptoServiceProvider random;
        private Random weakRandom;
    }
}
