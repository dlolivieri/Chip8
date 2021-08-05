using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    class ADDVxVy : IInstruction
    {
        /// <summary>
        /// 8xy4 - ADD Vx, Vy
        /// Set Vx = Vx + Vy, set VF = carry.
        /// The values of Vx and Vy are added together. If the result is greater than 8 bits(i.e., > 255,) VF is set to 1, otherwise 0.
        /// Only the lowest 8 bits of the result are kept, and stored in Vx.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte vx = opcode.GetNibble(1);
            byte vy = opcode.GetNibble(2);
            ushort result = (ushort)(core.Registers[vx] + core.Registers[vy]);
            core.Registers[0xF] = (byte)(result > 255 ? 1 : 0);
            core.Registers[vx] = (byte)(result & 0x00FF);

            core.IncrementPC();
        }
    }
}
