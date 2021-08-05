using Chip8.Emulator.Cpu;

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
            byte vx = opcode.X;
            ushort startIndex = core.Registers.I;

            for(int i = 0; i <= vx; i++)
                core.Memory.Write8(startIndex + i, core.Registers[i]);

            core.IncrementPC();
        }
    }
}
