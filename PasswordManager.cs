using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace PasswordGeneratorV2
{
    static public class PasswordManager
    {
        public static byte[] EncryptKey = Encoding.UTF8.GetBytes("YourSecretKey123");
        public static byte[] EncryptIV = Encoding.UTF8.GetBytes("YourSecretIV1234");

        static public Dictionary<string, byte[]> PasswordsList = new Dictionary<string, byte[]>();
        static public void SavePassword(string name, string password)
        {
            if (PasswordsList.ContainsKey(name)) { throw new PasswordAlreadyExists(); }
            PasswordsList[name] = Encrypt(password, EncryptKey, EncryptIV);
        }
        static public byte[] Encrypt(string plainText, byte[] key, byte[] IV)
        {
            byte[] encrypted = null;
            if (string.IsNullOrEmpty(plainText)) throw new ArgumentNullException("");
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }
        static public string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string PlainText = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            PlainText = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return PlainText;
        }
        static public void Serialize()
        {
            string JsonString = JsonSerializer.Serialize(PasswordsList);
            File.WriteAllText("PasswordsList.json", JsonString);
        }
        static public void Deserialize()
        {
            if (File.Exists("PasswordsList.json"))
            {
                var PasswordsJson = File.ReadAllText("PasswordsList.json");
                PasswordsList = JsonSerializer.Deserialize<Dictionary<string, byte[]>>(PasswordsJson);
            }
        }
    }
    public class PasswordAlreadyExists : Exception { }
}
