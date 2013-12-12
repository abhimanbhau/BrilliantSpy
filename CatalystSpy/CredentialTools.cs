using System;
using System.Collections.Generic;
using System.Text;
using KellermanSoftware.NetEncryptionLibrary;

namespace WinSpy
{
    class CredentialTools
    {
        const string password = "abhimanbhau";
        const string IV = "ask";
        const string salt = "kolte";
        public static bool validate(string ausername, string apassword)
        {
            Encryption encrypt = new Encryption();
            encrypt.InitializationVector = IV;
            encrypt.Salt = salt;
            string originalUsername = encrypt.DecryptString(EncryptionProvider.DES, password,
                Properties.Settings.Default.userName);
            string originalPassword = encrypt.DecryptString(EncryptionProvider.DES, password,
                Properties.Settings.Default.passWord);
            if (apassword == originalPassword && ausername == originalUsername)
            {
                return true;
            }
            else
                return false;
        }
        public static void changeCredentials(string newUsername, string newPassword)
        {
            Encryption encrypt = new Encryption();
            encrypt.InitializationVector = IV;
            encrypt.Salt = salt;
            string newEncryptedUsername = encrypt.EncryptString(EncryptionProvider.DES
                , password, newUsername);
            string newEncryptedPassword = encrypt.EncryptString(EncryptionProvider.DES
                , password, newPassword);
            Properties.Settings.Default.userName = newEncryptedUsername;
            Properties.Settings.Default.passWord = newEncryptedPassword;
            Properties.Settings.Default.Save();
        }
    }
}
