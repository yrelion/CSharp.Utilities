using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Utilities.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Checks whether the string represents a <see cref="Guid"/> of the specified format
        /// </summary>
        /// <param name="input">The string to check</param>
        /// <param name="format">One of the following specifiers that indicates the exact format to use when interpreting input: "N", "D", "B", "P", or "X".</param>
        /// <returns>The parsing operation result</returns>
        public static bool IsGuid(this string input, string format = null)
        {
            if (format == null)
                return Guid.TryParse(input, out Guid _);
            else
                return Guid.TryParseExact(input, format, out Guid _);
        }
    }
}
