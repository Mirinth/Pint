using System;

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
            Pint.UserInterface p = new Pint.UserInterface(Console.WriteLine);
            p.Run();

            Console.ReadLine();
        }
    }
}