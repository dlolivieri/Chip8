using System;

namespace Chip8.Emulator.Extensions
{
    public static class UShortExtensions
    {
        /// <summary>
        /// ushort Extension
        /// Return a nibble (4 bits) as a byte from a ushort (16 bits).
        /// </summary>
        /// <returns>A nibble as a byte in the form of 0x0X</returns>
        public static byte[] GetNibbles(this ushort us)
        {
            return new[] { (byte)(us >> 12), (byte)((us >> 8) & 0x0F), (byte)((us >> 4) & 0x0F), (byte)(us & 0x0F) };
        }

        /// <summary>
        /// Return a nibble (4 bits) as a byte from a ushort (16 bits).
        /// </summary>
        /// <param name="index">
        /// A value from 0-3. Left most Nibble in the short is 0, Right most Nibble is 3
        /// [0] = bits [0] -> [3]
        /// [1] = bits [4] -> [7]
        /// [2] = bits [8] -> [11]
        /// [3] = bits [12] -> [15]
        /// </param>
        /// <returns>A nibble (4 bits) as a byte</returns>
        public static byte GetNibble(this ushort us, int index)
        {
            if(index > 3) throw new ArgumentOutOfRangeException("index");

            int factor = (index % 3) * 4;
            return (byte)(us >> factor);      
        }

        public static byte GetLeftByte(this ushort us)
        {
            return (byte)(us >> 8);
        }
       
        public static byte GetRightByte(this ushort us)
        {
            return (byte)(us & 0x00FF);
        }

    }
}
