using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    /// <summary>
    /// 8xy1 - OR Vx, Vy
    /// Set Vx = Vx OR Vy.
    /// Performs a bitwise OR on the values of Vx and Vy, then stores the result in Vx.
    /// </summary>
    public class ORVxVy : IInstruction
    {
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte vx = opcode.GetNibble(1);
            byte vy = opcode.GetNibble(2);

            core.Registers[vy] |= core.Registers[vx];
            core.IncrementPC();
        }
    }
}
