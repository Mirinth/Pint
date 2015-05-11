using System;
using System.Collections.Generic;

namespace Pint
{
    /// <summary>
    /// The scanner takes in a code file and breaks it into pieces.
    /// </summary>
    static class Scanner
    {
        /// <summary>
        /// Determines whether a character is whitespace.
        /// </summary>
        /// <param name="c">The character to test.</param>
        /// <returns>Whether the character is a whitespace character.</returns>
        public static bool IsWhitespace(char c)
        {
            // Pint doesn't care about whitespace other than \r, \n, and space
            // right now.
            if (c == '\r' || c == '\n' || c == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}