using System.Collections.Generic;
using System.IO;

namespace Pint
{
    /// <summary>
    /// The scanner takes in a code file and breaks it into pieces.
    /// </summary>
    static class Scanner
    {
        /// <summary>
        /// Reads the contents of a TextReader and breaks them up into pieces.
        /// </summary>
        /// <param name="reader">The data source.</param>
        /// <returns>The contents of the data source, broken into pieces.</returns>
        public static List<string> Scan(TextReader reader)
        {
            const int eof = -1;

            List<string> pieces = new List<string>();
            string token = string.Empty;

            while (reader.Peek() != eof)
            {
                if (token.Length == 0 ||
                    IsWhitespace(token[token.Length - 1]) == IsWhitespace((char)reader.Peek()))
                {
                    token += (char)reader.Read();
                }
                else
                {
                    pieces.Add(token);
                    token = string.Empty;
                    token += (char)reader.Read();
                }
            }

            if (token.Length > 0)
            {
                pieces.Add(token);
            }

            return pieces;
        }

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