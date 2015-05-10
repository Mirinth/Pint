using System;

namespace Pint
{
    /// <summary>
    /// Executes the program's code.
    /// </summary>
    public static class CPU
    {
        private const int register_count = 32;

        private static UInt32 _ip;
        private static UInt32[] _registers;

        /// <summary>
        /// Initializes the CPU
        /// </summary>
        static CPU()
        {
            _ip = 0;
            _registers = new UInt32[register_count];

            for (int i = 0; i < register_count; i++)
            {
                _registers[i] = 0;
            }
        }

        /// <summary>
        /// Executes instructions in the MemoryManager until the
        /// contained program finishes.
        /// </summary>
        /// <param name="mmu">
        /// A MemoryManager containing the program to run.
        /// </param>
        public static void Run(MemoryManager mmu)
        {
        }

        /// <summary>
        /// Fetches the next instruction from memory
        /// and updates the instruction pointer.
        /// </summary>
        /// <param name="mmu">The program's memory.</param>
        /// <returns>The next instruction.</returns>
        {
            UInt32 instruction = mmu.ReadCode(_ip);
            _ip++;
            return instruction;
        }
    }
}