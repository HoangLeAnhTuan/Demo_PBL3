using System;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Text;
namespace Demo1.ViewModel
{
    public static class HashHelper
    {
        public static string GenerateSalt(int length = 16)
        {
            var random = new RNGCryptoServiceProvider();
            var salt = new byte[length];
            random.GetBytes(salt);
            return Convert.ToBase64String(salt);
        }

        public static string HashPassword(string password, string salt)
        {
            var combinedPassword = string.Concat(password, salt);
            var sha512 = new SHA512Managed();
            var bytes = Encoding.UTF8.GetBytes(combinedPassword);
            var hash = sha512.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public static bool VerifyPassword(string password, string salt, string hashedPassword)
        {
            var hash = HashPassword(password, salt);
            return hash == hashedPassword;
        }
    }
}

