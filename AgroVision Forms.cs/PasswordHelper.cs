using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AgroVision_Management_System.AgroVision_Forms.cs
{
    public static class PasswordHelper
    {
        public static string GenerateSalt(int length = 32)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] saltBytes = new byte[length];
                rng.GetBytes(saltBytes);
                return Convert.ToBase64String(saltBytes); // Return the salt as a Base64 string
            }
        }
        public static string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashBytes); // Convert hash to Base64 string
            }
        }
    }
}
