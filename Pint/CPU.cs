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
    }
}