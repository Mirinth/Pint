using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pint
{
    /// <summary>
    /// The parser takes a list of pieces collected by the scanner,
    /// validates them and returns a runnable code.
    /// </summary>
    public static class Parser
    {
        /// <summary>
        /// Takes a list of pieces collected by the scanner, validates
        /// them and returns a runnable code.
        /// </summary>
        /// <param name="pieces">A list of pieces collected by the scanner.</param>
        /// <returns>A runnable code.</returns>
        public static Dictionary<string, UInt32> Parse(List<string> pieces)
        {
            const int name_offset = 0;
            const int splitter_offset = 1;
            const int value_offset = 2;
            const int newline_offset = 3;
            const string splitter_value = " = ";

            Dictionary<string, UInt32> result = new Dictionary<string, uint>();
            string name = string.Empty;
            string splitter = string.Empty;
            UInt32 value = 0;
            string newline = string.Empty;

            for (int i = 0; i < pieces.Count - 4; i += 4)
            {
                if (IsNewline(pieces[i]))
                {
                    continue;
                }

                name = pieces[i + name_offset];
                splitter = pieces[i + splitter_offset];
                value = UInt32.Parse(pieces[i + value_offset]);
                newline = pieces[i + newline_offset];

                if (splitter != splitter_value || !IsNewline(newline))
                {
                    throw new FormatException();
                }

                if (result.ContainsKey(name))
                {
                    result[name] = value;
                }
                else
                {
                    result.Add(name, value);
                }
            }

            return result;
        }

        /// <summary>
        /// Tests whether a string is a newline.
        /// </summary>
        /// <param name="test">The string to test.</param>
        /// <returns>Whether the string is a newline.</returns>
        public static bool IsNewline(string test)
        {
            if (test == "\r\n" || test == "\r" || test == "\n" || test == "\n\r")
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