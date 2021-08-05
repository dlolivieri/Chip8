using Chip8.Emulator.Cpu;
using System;

namespace Chip8.Emulator.Instructions.Implementation
{
    class LDVxI : IInstruction
    {
        /// <summary>
        /// Fx65 - LD Vx, [I]
        /// Read registers V0 through Vx from memory starting at location I.
        /// The interpreter reads values from memory starting at location I into registers V0 through Vx.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte vx = opcode.GetNibble(1);
            ushort startIndex = core.Registers.I;

            for (int i = 0; i <= vx; i++)
                core.Registers[i] = core.Memory.Read8(startIndex + i);

            core.IncrementPC();
        }
    }
}
