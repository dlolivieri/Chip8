using System.Collections.Generic;

namespace Chip8.Emulator.Extensions
{
    public static class IntExtensions
    {
        /// <summary>
        /// Return a nibble (4 bits)
        /// </summary>
        /// <param name="index">A value from 0-2. 
        /// [0] = bits [0] -> [3]
        /// [1] = bits [4] -> [7]
        /// </param>
        /// <returns>A nibble as a byte in the form of 0x0X</returns>
        public static int[] GetNibbles(this int value)
        {
            List<int> nibbles = new List<int>();

            for(int i = 8; i > 0; i++)
            {
                int factor = i * 4;
                nibbles.Add((value >> factor) & 0xF);
            }

            return nibbles.ToArray();
        }
    }
}
