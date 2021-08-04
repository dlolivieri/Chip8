using Chip8.Emulator.Cpu;
using System;

namespace Chip8.Emulator.Instructions.Implementation
{
    class LDIVx : IInstruction
    {
        /// <summary>
        /// Fx55 - LD [I], Vx
        /// Store registers V0 through Vx in memory starting at location I.
        /// The interpreter copies the values of registers V0 through Vx into memory, starting at the address in I.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            throw new NotImplementedException();
        }
    }
}
