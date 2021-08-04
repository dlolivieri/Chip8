using Chip8.Emulator.Cpu;
using System;

namespace Chip8.Emulator.Instructions.Implementation
{
    class LDDTVx : IInstruction
    {
        /// <summary>
        /// Fx15 - LD DT, Vx
        /// Set delay timer = Vx.
        /// DT is set equal to the value of Vx.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            throw new NotImplementedException();
        }
    }
}
