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
                if (!(Directory.Exists(Properties.Settings.Default.homeDirectory
                    + "\\ENCRYPTED")))
                {
                    Directory.CreateDirectory(Properties.Settings.Default.homeDirectory
                        + "\\ENCRYPTED");
                }
                Encryption encrypt = new Encryption();
                encrypt.Salt = "kolte";
                encrypt.InitializationVector = "ask";
                var name = Path.GetFileName(inputPath);
                string outFile = Properties.Settings.Default.homeDirectory
                    + "\\ENCRYPTED\\" + name;
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
                if (!(Directory.Exists(Properties.Settings.Default.homeDirectory
                    + "\\DECRYPTED")))
                {
                    Directory.CreateDirectory(Properties.Settings.Default.homeDirectory
                        + "\\DECRYPTED");
                }
                Encryption encrypt = new Encryption();
                encrypt.Salt = "kolte";
                encrypt.InitializationVector = "ask";
                var name = Path.GetFileName(inputPath);
                string outFile = Properties.Settings.Default.homeDirectory
                    + "\\DECRYPTED\\" + name;
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
