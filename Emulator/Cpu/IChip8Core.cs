namespace Chip8.Emulator.Cpu
{
    public interface IChip8Core
    {
        /// <summary>
        /// Program Counter
        /// </summary>
        ushort PC { get; set; }

        void IncrementPC();

        /// <summary>
        /// Stack Pointer
        /// </summary>
        byte SP { get; set; }

        /// <summary>
        /// Chip8 Registers
        /// </summary>
        IChip8Registers Registers { get; }

        /// <summary>
        /// Chip8 Memory
        /// </summary>
        IChip8Memory Memory { get; }

        /// <summary>
        /// Chip8 Stack
        /// </summary>
        IChip8Stack Stack { get; }
    }
}
