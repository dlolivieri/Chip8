namespace Chip8.Emulator.Instructions
{
    public interface IOpcode
    {
        ushort Code { get; }
        public byte[] Nibbles { get; }
        public byte LeftByte { get; }

        public byte RightByte { get; }

        public byte GetNibble(int index);

        public ushort GetNNN();

        public byte GetInstructionIdentifier();
    }   
}
