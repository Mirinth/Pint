using System;
using System.IO;

namespace Pint
{
    /// <summary>
    /// This is the stuff that everybody else who uses the library can see.
    /// </summary>
    public class UserInterface
    {
        private Action<string> write;

        /// <summary>
        /// Initializes the UserInterface.
        /// </summary>
        public UserInterface(Action<string> writer)
        {
            write = writer;
        }

        /// <summary>
        /// Runs the interpreter.
        /// </summary>
        public void Run()
        {
            const string hard_coded_file_path = "code.pcf";
            const int max_line_length = 9;

            int result = 0;
            bool resultSet = false;

            try
            {
                string[] lines = File.ReadAllLines(hard_coded_file_path);

                foreach (string line in lines)
                {
                    if (line.Length > max_line_length)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    if (line.Length > 0)
                    {
                        result = int.Parse(line);
                        resultSet = true;
                    }
                }

                if (resultSet)
                {
                    write(result.ToString());
                }
                else
                {
                    write("I give up.");
                }
            }
            catch (Exception)
            {
                write("I give up.");
            }
        }
    }
}