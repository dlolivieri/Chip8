namespace Chip8.Emulator.Instructions
{
    public interface IOpcode
    {
        ushort Code { get; }

        byte[] Nibbles { get; }

        byte LeftByte { get; }

        byte RightByte { get; }

        /// <summary>
        /// Get the first nibble of the ushort code as a byte
        /// </summary>
        byte InstructionId { get; }

        /// <summary>
        /// Get nXnn nibble of the ushort Code as a byte in the format of 0xX
        /// </summary>
        byte X { get; }

        /// <summary>
        /// Get nnYn nibble of the ushort Code as a byte in the format of 0xY
        /// </summary>
        byte Y { get; }

        /// <summary>
        /// Get the last 3 Nibbles of the ushort as a ushort in the format of 0x0NNN
        /// </summary>
        ushort NNN { get; }

        byte GetNibble(int index);
    }   
}
