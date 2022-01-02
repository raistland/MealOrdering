using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MealOrdering.Shared.Utils
{
    public class PasswordEncrypter
    {

        public static String Encrypt(String Password)
        {
            // Kendi algoritmanızı kullanabilirsiniz.
            // Ben Base64 olarak kullanıyorum
            using (SHA256 sha256Hash = SHA256.Create())
            {
                var plainTextBytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(Password));
                return Convert.ToBase64String(plainTextBytes);
            }
        }


    }
}
