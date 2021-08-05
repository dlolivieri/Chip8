using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    public class SNEVx : IInstruction
    {
        /// <summary>
        /// 4xkk - SNE Vx, byte
        /// Skip next instruction if Vx != kk.
        /// The interpreter compares register Vx to kk, and if they are not equal, increments the program counter by 2.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte vx = opcode.X;
            byte kk = (byte)(opcode.Code & 0x00FF);
            core.PC += vx != kk ? (ushort)2 : (ushort)1;
        }
    }
}
