using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EncryptDecryptConfig
{
    class Program
    {
        private static readonly string EncryptionKey = "THILLAISHANMUGAM_"; // Use a secure key
        private static readonly string Salt = "_THILLAISHANMUGAM"; // Use a secure salt

        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Administrator\Desktop\TEST\Encryption\EncryptDecryptConfig\EncryptDecryptConfig\DBconfig\DBConnectionString.ini";

            // Read and encrypt the file
            EncryptFile(filePath);

            // Decrypt the file
            DecryptFile(filePath);

            Console.WriteLine("Encryption and Decryption completed. Check the file contents.");
        }

        public static void EncryptFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string connString = File.ReadAllText(filePath);
                    string encryptedConnString = Encrypt(connString);
                    File.WriteAllText(filePath, encryptedConnString);
                    Console.WriteLine("File encrypted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error encrypting file: {ex.Message}");
            }
        }

        public static void DecryptFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string encryptedConnString = File.ReadAllText(filePath);
                    string decryptedConnString = Decrypt(encryptedConnString);
                    File.WriteAllText(filePath, decryptedConnString);
                    Console.WriteLine("File decrypted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error decrypting file: {ex.Message}");
            }
        }

        public static string Encrypt(string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = GenerateEncryptionKey(EncryptionKey, Salt);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string Decrypt(string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = GenerateEncryptionKey(EncryptionKey, Salt);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        private static byte[] GenerateEncryptionKey(string key, string salt)
        {
            using (var keyDerivationFunction = new Rfc2898DeriveBytes(key, Encoding.UTF8.GetBytes(salt), 10000))
            {
                return keyDerivationFunction.GetBytes(32); // 32 bytes for AES-256
            }
        }
    }
}
