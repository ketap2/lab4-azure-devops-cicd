using System;

namespace StringExtensions
{
    /// <summary>
    /// Provides extension methods for the string class.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Checks if the string starts with an uppercase letter.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <returns>True if the string starts with an uppercase letter, otherwise false.</returns>
        public static bool StartsWithUpperCase(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            return char.IsUpper(str[0]);
        }
    }
}
