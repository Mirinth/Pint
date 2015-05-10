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
        {
            if (_code != null)
            {
                throw new InvalidOperationException("Re-initialization of the memory manager is unsupported");
            }

            _code = new byte[codeImage.Length];
            codeImage.CopyTo(_code, 0);
        }
    }
}
