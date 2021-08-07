using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{

    public class SEVx : IInstruction
    {
        /// <summary>
        /// 3xkk - SE Vx, byte
        /// Skip next instruction if Vx = kk.
        /// The interpreter compares register Vx to kk, and if they are equal, increments the program counter by 2.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte vx = opcode.X;
            byte kk = (byte)(opcode.Code & 0x00FF);

            if (core.Registers[vx] == kk)
                core.IncrementPC();
        }
    }
}
