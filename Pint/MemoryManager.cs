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
            _code = new byte[0];
            _data = new byte[MAX_DATA_MEMORY];
        }
    }
}
