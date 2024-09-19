using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace PZ1_ZyryanovaDA
{
    public static class HashPasswords
    {
        public static string Hash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Преобразуем строку в байты
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Преобразуем байты в строку в формате hex
                //StringBuilder builder = new StringBuilder();
                //foreach (byte b in bytes)
                //{
                //    builder.Append(b.ToString("x2"));
                //}
                //return builder.ToString();
                return BitConverter.ToString(bytes).Replace("-", "");
            }
        }
    }
}
