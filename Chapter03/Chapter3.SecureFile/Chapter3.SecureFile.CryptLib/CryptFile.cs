using System;
using System.IO;

namespace Chapter3.SecureFile.CryptLib
{
    public class CryptFile
    {
        private string _fileName;

        public CryptFile(string fileName)
        {
            _fileName = fileName;
        }

        public void EncryptFile()
        {
            File.Encrypt(_fileName);
        }

        public void DecryptFile()
        {
            File.Decrypt(_fileName);
        }
        
    }
}
