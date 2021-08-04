using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    class CLS : IInstruction
    {
        /// <summary>
        /// 00E0 - CLS
        /// Clear the display.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            throw new System.NotImplementedException();
        }
    }
}
