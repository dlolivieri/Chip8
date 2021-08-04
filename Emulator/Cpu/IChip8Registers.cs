namespace Chip8.Emulator.Cpu
{
    public interface IChip8Registers
    {
        ushort I { get; set; }
        byte[] registers { get; }

        byte this[int i] { get; set; }

        int RegisterCount { get; }
    }
}