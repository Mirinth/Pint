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
        /// Initializes the memory manager some blank data memory
        /// and no code memory.
        /// </summary>
        public MemoryManager()
        {
            const int MAX_DATA_MEMORY = 0xffff;
            _code = null;
            _data = new byte[MAX_DATA_MEMORY];
        }

        /// <summary>
        /// Initializes the program's code space.
        /// Code is read-only and may only be initialized once.
        /// </summary>
        /// <param name="codeImage">An image of the program's code.</param>
        public void LoadCode(byte[] codeImage)
        {
            if (_code != null)
            {
                throw new InvalidOperationException("Re-initialization of the memory manager is unsupported");
            }

            _code = new byte[codeImage.Length];
            codeImage.CopyTo(_code, 0);
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
