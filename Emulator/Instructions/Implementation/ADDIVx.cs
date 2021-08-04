using Chip8.Emulator.Cpu;
using System;

namespace Chip8.Emulator.Instructions.Implementation
{
    public class ADDIVx : IInstruction
    {
        /// <summary>
        /// Fx1E - ADD I, Vx
        /// Set I = I + Vx.
        /// The values of I and Vx are added, and the results are stored in I.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode) 
        {
            if (core == null) throw new ArgumentNullException("core");
            if (opcode == null) throw new ArgumentNullException("opcode");

            byte vx = opcode.GetNibble(1);
            ushort i = core.Registers.I;
            //TODO: What happens if the addition overflows the byte?
            core.Registers.I += core.Registers[vx];
            core.IncrementPC();
        }
    }
}
