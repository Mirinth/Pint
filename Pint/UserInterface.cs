using System;
using System.IO;
using System.Collections.Generic;

namespace Pint
{
    /// <summary>
    /// This is the stuff that everybody else who uses the library can see.
    /// </summary>
    public class UserInterface
    {
        public delegate void WriterDelegate(string format, params object[] values);
        private WriterDelegate write;

        /// <summary>
        /// Initializes the UserInterface.
        /// </summary>
        public UserInterface(WriterDelegate writer)
        {
            write = writer;
        }

        /// <summary>
        /// Runs the interpreter.
        /// </summary>
        public void Run(TextReader reader)
        {
            try
            {
                List<string> pieces = Scanner.Scan(reader);
                Dictionary<string, UInt32> parsed = Parser.Parse(pieces);

                foreach(KeyValuePair<string, UInt32> kvp in parsed)
                {
                    write("{0} = {1}", kvp.Key, kvp.Value);
                }
            }
            catch (Exception)
            {
                write("I give up.");
            }
        }
    }
}