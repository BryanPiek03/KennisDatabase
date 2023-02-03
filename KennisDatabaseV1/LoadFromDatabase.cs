using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KennisDatabaseV1
{
    internal class LoadFromDatabase
    {

        public static List<BsonDocument> documentList = new List<BsonDocument>();

        public static MongoClient client = new MongoClient();

        async public static void Load()
        {
            string cipherText = "3LWM2VW0o65XYYgqksnC7rKXa0Umoc3h6xUKtqIrssPmddD656Hetv+m+qCFuJfRxtUDhjQKYtV8Sqb6lipuo9f7RtQpsjFpN613LTgdW5c0MZVQZ5bgw4zP3pj161dQ";
            string key = "";

            byte[] data = Convert.FromBase64String(key);
            key = Encoding.UTF8.GetString(data);

            string plaintext = DecryptString(cipherText, key);
            client = new MongoClient(plaintext);
            var database = client.GetDatabase("w4schools");
            var collection = database.GetCollection<BsonDocument>("csharp");

            var documents = collection.Find(new BsonDocument()).ToList();

            
            foreach (var document in documents)
            {
                documentList.Add(document);
            }

        }

        public static string DecryptString(string cipherText, string key)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            Aes aes = Aes.Create();
            aes.Key = keyBytes;
            aes.IV = new byte[aes.BlockSize / 8];
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.PKCS7;
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using (MemoryStream ms = new MemoryStream(cipherBytes))
            using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
            using (StreamReader sr = new StreamReader(cs))
            {
                // Return the goofy ass decrypted string thing.
                return sr.ReadToEnd();
            }
        }

    }
}
