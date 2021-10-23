using System;

namespace CSharp.Utilities.Strings
{
    public static class StringExtensions
    {
        /// <summary>
        /// Extension method to format string with passed arguments. Current thread's current culture is used
        /// </summary>
        /// <param name="format">string format</param>
        /// <param name="args">arguments</param>
        /// <returns>The formatted string</returns>
        public static string FormatWith(this string format, params object[] args)
        {
            return string.Format(format, args);
        }

        /// <summary>
        /// Extension method to format string with passed arguments using specified format provider (i.e. CultureInfo)
        /// </summary>
        /// <param name="format">string format</param>
        /// <param name="provider">An object that supplies culture-specific formatting information</param>
        /// <param name="args">arguments</param>
        /// <returns>The formatted string</returns>
        public static string FormatWith(this string format, IFormatProvider provider, params object[] args)
        {
            return string.Format(provider, format, args);
        }

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
