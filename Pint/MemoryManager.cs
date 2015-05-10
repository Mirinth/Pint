using System;

namespace Pint
{
    /// <summary>
    /// Manages the memory visible to the program.
    /// </summary>
    class MemoryManager
    {
        private byte[] _code;
        private byte[] _data;

        /// <summary>
        /// Initializes the memory manager with some blank data
        /// memory and no code memory.
        /// </summary>
        public MemoryManager(byte[] code, byte[] data)
        {
            _code = new byte[code.Length];
            code.CopyTo(_code, 0);

            _data = new byte[data.Length];
            data.CopyTo(_data, 0);
        }

        /// <summary>
        /// Reads from the code image at the given index.
        /// </summary>
        /// <param name="index">The index to read from.</param>
        /// <returns>The byte in the code image at index.</returns>
        public byte ReadCode(int index)
        {
            return _code[index];
        }

        /// <summary>
        /// Reads from the data image at the given index.
        /// </summary>
        /// <param name="index">The index to read from.</param>
        /// <returns>The byte in the data image at index.</returns>
        public byte ReadData(int index)
        {
            return _data[index];
        }

        /// <summary>
        /// Writes to the data image at the given index.
        /// </summary>
        /// <param name="index">The index to write to.</param>
        /// <param name="value">The value to write.</param>
        public void WriteData(int index, byte value)
        {
            _data[index] = value;
        }
    }
}