using System;
using System.Security.Cryptography;
using System.Text;

namespace SemgrepTestProject.Utils
{
    public class SecurityHelper
    {
        public static string HashPassword(string password)
        {
            using (MD5 md5 = MD5.Create())  // 🚨 Weak hashing algorithm
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
