using Chip8.Emulator.Cpu;
using System;

namespace Chip8.Emulator.Instructions.Implementation
{
    class RET : IInstruction
    {
        /// <summary>
        /// 00EE - RET
        /// Return from a subroutine.
        /// The interpreter sets the program counter to the address at the top of the stack, then subtracts 1 from the stack pointer.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            core.SP--;
            //TODO Finish
            throw new NotImplementedException();       
        }
    }
}
