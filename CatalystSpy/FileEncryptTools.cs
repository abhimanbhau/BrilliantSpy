using System;
using System.Collections.Generic;
using System.Text;
using KellermanSoftware.NetEncryptionLibrary;
using System.IO;

namespace CatalystSpy
{
    class FileEncryptTools
    {
        public static void encryptFile(string inputPath, string password)
        {
            try
            {
                if (!(Directory.Exists(Properties.Settings.Default.encryptedFilesDirectory)))
                {
                    Directory.CreateDirectory(Properties.Settings.Default.encryptedFilesDirectory);
                }
                Encryption encrypt = new Encryption();
                encrypt.Salt = "kolte";
                encrypt.InitializationVector = "ask";
                var name = Path.GetFileName(inputPath);
                string outFile = Properties.Settings.Default.encryptedFilesDirectory + @"\" + name;
                encrypt.EncryptFile(EncryptionProvider.Rijndael, password, inputPath,
                    outFile);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void decryptFile(string inputPath, string password)
        {
            try
            {
                if (!(Directory.Exists(Properties.Settings.Default.decryptedFilesDirectory)))
                {
                    Directory.CreateDirectory(Properties.Settings.Default.decryptedFilesDirectory);
                }
                Encryption encrypt = new Encryption();
                encrypt.Salt = "kolte";
                encrypt.InitializationVector = "ask";
                var name = Path.GetFileName(inputPath);
                string outFile = Properties.Settings.Default.decryptedFilesDirectory + @"\" + name;
                encrypt.DecryptFile(EncryptionProvider.Rijndael, password, inputPath,
                    outFile);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
