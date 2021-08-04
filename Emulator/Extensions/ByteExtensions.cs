using System;

namespace Chip8.Emulator.Extensions
{
    public static class ByteExtensions
    {
        /// <summary>
        /// Return a nibble (4 bits) as a byte from a byte.
        /// </summary>
        /// <param name="index">A value from 0-2. 
        /// [0] = bits [0] -> [3]
        /// [1] = bits [4] -> [7]
        /// </param>
        /// <returns>A nibble as a byte in the form of 0x0X</returns>
        public static byte[] GetNibbles(this byte b)
        {
            return new[] { (byte)(b >> 4), (byte)(b & 0x0F) };
        }

        public static ushort Read16(this byte[] b, int index)
        {
            if (index >= b.Length - 1) throw new IndexOutOfRangeException();

            return (ushort)(b[index] << 8 | b[index + 1]);
        }

        public static void Write16(this byte[] b, int index, ushort value)
        {
            if (index >= b.Length - 1) throw new IndexOutOfRangeException();

            b[index] = value.GetLeftByte();
            b[index + 1] = value.GetRightByte();
        }
    }
}
