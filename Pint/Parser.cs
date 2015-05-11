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