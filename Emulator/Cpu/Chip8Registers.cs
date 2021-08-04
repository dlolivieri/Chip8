namespace Chip8.Emulator.Cpu
{
    public class Chip8Registers : IChip8Registers
    {
        public static int NUMBER_OF_REGISTERS = 16;
        public int RegisterCount => NUMBER_OF_REGISTERS;

        /// <summary>
        /// Registers. 16 bytes long.
        /// </summary>
        public byte[] registers { get; } = new byte[NUMBER_OF_REGISTERS];

        /// <summary>
        /// Indexer for registers
        /// </summary>
        /// <returns>The value stored in registers[index]</returns>
        public byte this[int index] 
        {
            get => registers[index];
            set => registers[index] = value;                
        }

        /// <summary>
        /// Address register. 12 bits wide.
        /// </summary>
        public ushort I { get; set; }   
    }
}
