using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    class JP : IInstruction
    {
        /// <summary>
        /// 1nnn - JP addr
        /// Jump to location nnn.
        /// The interpreter sets the program counter to nnn.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            ushort nnn = opcode.GetNNN();
            core.PC = nnn;
        }
    }
}
