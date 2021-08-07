using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    public class XORVxVy : IInstruction
    {
        /// <summary>
        /// 8xy3 - XOR Vx, Vy
        /// Set Vx = Vx XOR Vy.
        /// Performs a bitwise exclusive OR on the values of Vx and Vy, then stores the result in Vx.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte vx = opcode.X;
            byte vy = opcode.Y;

            core.Registers[vx] ^= core.Registers[vy];

            core.IncrementPC();
        }
    }
}
