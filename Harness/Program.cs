using System;
using System.IO;

namespace UI
{
    /// <summary>
    /// Contains the main entry point for the program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main entry point for the program.
        /// </summary>
        /// <param name="args">Ignored.</param>
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please give a file name to use when running the program.");
                Console.WriteLine("e.g. Harness.exe path/to/some/file.pcf");
                return;
            }

            try
            {
                TextReader reader = new StreamReader(new FileStream(args[0], FileMode.Open, FileAccess.Read, FileShare.Read));
                Pint.UserInterface p = new Pint.UserInterface(Console.WriteLine);
                p.Run(reader);
            }
            catch (Exception)
            {
                Console.WriteLine("I give up.");
            }

            Console.ReadLine();
        }
    }
}