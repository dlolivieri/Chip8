namespace Chip8.Emulator.Cpu
{
    public interface IChip8Memory
    {
        /// <summary>
        /// Total amount of bytes allocated in MemorySpace
        /// </summary>
        static uint MEMORY_SIZE { get; }

        /// <summary>
        /// Byte array with length of MEMORY_SIZE
        /// </summary>
        byte[] MemorySpace { get; }

        /// <summary>
        /// Read the byte at index and index + 1 combined as a ushort.
        /// </summary>
        /// <param name="index">MemorySpace index to start reading at. Must be less than MEMORY_SIZE - 1</param>
        /// <returns>Byte at index and index + 1 combined as a ushort</returns>
        ushort Read16(int index);

        /// <summary>
        /// Read the byte at index.
        /// </summary>
        /// <param name="index">MemorySpace index to read.</param>
        /// <returns>The byte at index in MemorySpace.</returns>
        byte Read8(int index);

        /// <summary>
        /// Write the byte at index and index + 1 by splitting a ushort into two bytes.
        /// </summary>
        /// <param name="index">The index to start writing.</param>
        /// <param name="value">The value to be split into two bytes.</param>
        void Write16(int index, ushort value);

        /// <summary>
        /// Write a byte to memory at a given index.
        /// </summary>
        /// <param name="index">The index to write to.</param>
        /// <param name="value">The value to write.</param>
        void Write8(int index, byte value);
    }
}