using System.Collections.Generic;

namespace Chip8.Emulator.Cpu
{
    public class Chip8Stack : List<ushort>, IChip8Stack
    {
        public void Push(ushort value)
        {
            Insert(0, value);
        }
    }
}
