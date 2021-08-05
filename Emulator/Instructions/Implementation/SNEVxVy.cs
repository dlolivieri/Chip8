using Chip8.Emulator.Cpu;
using System;

namespace Chip8.Emulator.Instructions.Implementation
{
    public class SNEVxVy : IInstruction
    {
        /// <summary>
        /// 9xy0 - SNE Vx, Vy
        /// Skip next instruction if Vx != Vy.
        /// The values of Vx and Vy are compared, and if they are not equal, the program counter is increased by 2.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte vx = opcode.X;
            byte vy = opcode.Y;
            core.PC += vx != vy ? (ushort)2 : (ushort)1;
        }
    }
}
