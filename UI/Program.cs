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
            const string code_path = @"code.bin";
            const string data_path = @"data.bin";

            byte[] code = File.ReadAllBytes(code_path);
            byte[] data = File.ReadAllBytes(data_path);

            Pint.MemoryManager mmu = new Pint.MemoryManager(code, data);
            Pint.CPU.Run(mmu);
        }
    }
}