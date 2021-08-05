using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    class SHRVxVy : IInstruction
    {
        /// <summary>
        /// 8xy6 - SHR Vx {, Vy}
        /// Set Vx = Vx SHR 1.
        /// If the least-significant bit of Vx is 1, then VF is set to 1, otherwise 0. Then Vx is divided by 2.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte vx = opcode.GetNibble(1);
            core.Registers[0x0F] = (byte)(core.Registers[vx] & 0x01);
            core.Registers[vx] = (byte)(core.Registers[vx] >> 1);

            core.IncrementPC();
        }
    }
}
