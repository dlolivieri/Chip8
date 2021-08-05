using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    /// <summary>
    /// 6xkk - LD Vx, byte
    /// Set Vx = kk.
    /// The interpreter puts the value kk into register Vx.
    /// </summary>
    public class LDVx : IInstruction
    {
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte vx = opcode.X;
            byte kk = opcode.RightByte;
            core.Registers[vx] = kk;
            core.IncrementPC();
        }
    }
}
