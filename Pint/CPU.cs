﻿using System;

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
            UInt32 src1,
                   src2,
                   dest;

            UInt32 instruction = FetchInstruction(mmu);
            FetchRegisters(instruction, out src1, out src2, out dest);
        }

        /// <summary>
        /// Fetches the next instruction from memory
        /// and updates the instruction pointer.
        /// </summary>
        /// <param name="mmu">The program's memory.</param>
        /// <returns>The next instruction.</returns>
        public static UInt32 FetchInstruction(MemoryManager mmu)
        {
            UInt32 instruction = mmu.ReadCode(_ip);
            _ip++;
            return instruction;
        }

        /// <summary>
        /// Fetches the registers associated with a given instruction.
        /// Note that some or all of these may be garbage if the instruction
        /// doesn't actually need a particular register (e.g. if the instruction
        /// only uses one source register, then src2 will be garbage).
        /// </summary>
        /// <param name="instruction">The instruction to fetch registers for.</param>
        /// <param name="dest">The destination register for the instruction.</param>
        /// <param name="src1">The first source register for the instruction.</param>
        /// <param name="src2">The second source register for the instruction.</param>
        public static void FetchRegisters(UInt32 instruction, out UInt32 dest, out UInt32 src1, out UInt32 src2)
        {
            const int mask = 0x0f; // Zeros all but the first four bits
            const int dest_start = 7;
            const int src1_start = 15;
            const int src2_start = 20;

            // Shift the desired value so it starts at position 0,
            // then mask away everything else.
            dest = (instruction >> dest_start) & mask;
            src1 = (instruction >> src1_start) & mask;
            src2 = (instruction >> src2_start) & mask;
        }
    }
}