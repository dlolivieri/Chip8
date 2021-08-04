using Chip8.Emulator.Extensions;
using System;

namespace Chip8.Emulator.Cpu
{
    public class Chip8Memory : IChip8Memory
    {
        /// <summary>
        /// Number of bytes allocated to memory space
        /// </summary>
        public static uint MEMORY_SIZE => 4096;

        public byte[] MemorySpace { get; }

        public Chip8Memory(byte[] memorySpace)
        {
            if (memorySpace == null) throw new ArgumentNullException();
            if (memorySpace.Length < MEMORY_SIZE) throw new ArgumentException($"Must allocate at least {MEMORY_SIZE} bytes for memory.");

            MemorySpace = memorySpace;
        }

        public Chip8Memory()
            : this(new byte[MEMORY_SIZE])
        {             
        }

        public byte Read8(int index)
        {
            return MemorySpace[index];
        }

        public void Write8(int index, byte value)
        {
            MemorySpace[index] = value;
        }

        public ushort Read16(int index)
        {
            return MemorySpace.Read16(index);
        }

        public void Write16(int index, ushort value)
        {
            MemorySpace.Write16(index, value);
        }

    }
}
