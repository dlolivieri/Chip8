using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    class LDI : IInstruction
    {
        /// <summary>
        /// Annn - LD I, addr
        /// Set I = nnn.
        /// The value of register I is set to nnn.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            ushort nnn = opcode.GetNNN();
            core.Registers.I = nnn;
            core.IncrementPC();
        }
    }
}
