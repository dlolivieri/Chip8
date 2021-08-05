﻿using Chip8.Emulator.Extensions;

namespace Chip8.Emulator.Instructions
{
    public class Opcode : IOpcode
    {
        public ushort Code { get; }

        protected byte[] _nibbles;

        public byte[] Nibbles => _nibbles ??= Code.GetNibbles();

        protected byte? _leftByte;
        public byte LeftByte => _leftByte ??= Code.GetLeftByte();

        protected byte? _rightByte;
        public byte RightByte => _rightByte ??= Code.GetRightByte();

        public byte X => GetNibble(1);

        public byte Y => GetNibble(2);

        public ushort NNN => (ushort)(Code & 0x0FFF);

        public Opcode(ushort code)
        {
            Code = code;
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
        public byte GetNibble(int index)
        {
            return Code.GetNibble(index);
        }

        public byte GetInstructionIdentifier()
        {
            return Code.GetNibble(0);
        }
    }
}
