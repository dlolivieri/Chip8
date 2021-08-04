using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    class JPV0 : IInstruction
    {
        /// <summary>
        /// Bnnn - JP V0, addr
        /// Jump to location nnn + V0.
        /// The program counter is set to nnn plus the value of V0.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte v0 = core.Registers[0];
            ushort nnn = opcode.GetNNN();
            core.PC = (ushort)(v0 + nnn);
        }
    }
}
