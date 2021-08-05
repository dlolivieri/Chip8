using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    class ANDVxVy : IInstruction
    {
        /// <summary>
        /// 8xy2 - AND Vx, Vy
        /// Set Vx = Vx AND Vy.
        /// Performs a bitwise AND on the values of Vx and Vy, then stores the result in Vx.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte vx = opcode.GetNibble(1);
            byte vy = opcode.GetNibble(2);

            core.Registers[vx] &= core.Registers[vy];
        }
    }
}
