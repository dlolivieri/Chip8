using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    /// <summary>
    /// 8xy0 - LD Vx, Vy
    /// Set Vx = Vy.
    /// Stores the value of register Vy in register Vx.
    /// </summary>
    public class LDVxVy : IInstruction
    {
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte vx = opcode.X;
            byte vy = opcode.Y;

            core.Registers[vy] = core.Registers[vx];
            core.IncrementPC();
        }
    }
}
