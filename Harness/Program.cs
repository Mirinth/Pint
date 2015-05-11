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
            Console.WriteLine("Enter a file name to run: ");
            string path = Console.ReadLine();

            try
            {
                TextReader reader = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read));
                Pint.UserInterface p = new Pint.UserInterface(Console.WriteLine);
                p.Run(reader);
                Console.WriteLine("Done!");
            }
            catch (Exception)
            {
                Console.WriteLine("I give up.");
            }

            Console.ReadLine();
        }
    }
}