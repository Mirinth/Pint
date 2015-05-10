using System;
using System.IO;
using System.Security;

namespace Pint
{
    /// <summary>
    /// Loads the program's image from disk.
    /// </summary>
    class Loader
    {
        /// <summary>
        /// Loads a program off the disk, creating a new memory manager.
        /// </summary>
        /// <param name="codeImgPath">The path to the code image.</param>
        /// <param name="dataImgPath">The path to the data image.</param>
        /// <returns>A MemoryManager containing the specified images, or null on failure.</returns>
        public static MemoryManager Load(string codeImgPath, string dataImgPath)
        {
            try
            {
                byte[] code = File.ReadAllBytes(codeImgPath);
                byte[] data = File.ReadAllBytes(dataImgPath);
                return new MemoryManager(code, data);
            }
            catch (ArgumentException) { return null; }
            catch (IOException) { return null; }
            catch (UnauthorizedAccessException) { return null; }
            catch (NotSupportedException) { return null; }
            catch (SecurityException) { return null; }
            // These are subtypes of the above, left as reminders
            // in case they need special handling later.

            // catch (ArgumentNullException) { return null; }
            // catch (PathTooLongException) { return null; }
            // catch (DirectoryNotFoundException) { return null; }
            // catch (FileNotFoundException) { return null; }
        }
    }
}