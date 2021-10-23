using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CSharp.Utilities.Extensions
{
    public static class HashExtensions
    {
        /// <summary>Creates a SHA256 hash of the specified input.</summary>
        /// <param name="input">The input.</param>
        /// <returns>A hash</returns>
        public static string Sha256(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;
            using (SHA256 shA256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                return Convert.ToBase64String(shA256.ComputeHash(bytes));
            }
        }

        /// <summary>Creates a SHA256 hash of the specified input.</summary>
        /// <param name="input">The input.</param>
        /// <returns>A hash.</returns>
        public static byte[] Sha256(this byte[] input)
        {
            if (input == null)
                return (byte[])null;
            using (SHA256 shA256 = SHA256.Create())
                return shA256.ComputeHash(input);
        }

        /// <summary>Creates a SHA512 hash of the specified input.</summary>
        /// <param name="input">The input.</param>
        /// <returns>A hash</returns>
        public static string Sha512(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;
            using (SHA512 shA512 = SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                return Convert.ToBase64String(shA512.ComputeHash(bytes));
            }
        }
    }
}
