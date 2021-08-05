using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    class SUBVxVy : IInstruction
    {
        /// <summary>
        /// 8xy5 - SUB Vx, Vy
        /// Set Vx = Vx - Vy, set VF = NOT borrow.
        /// If Vx > Vy, then VF is set to 1, otherwise 0. Then Vy is subtracted from Vx, and the results stored in Vx.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte vx = opcode.X;
            byte vxValue = core.Registers[vx];

            byte vy = opcode.Y;
            byte vyValue = core.Registers[vy];

            core.Registers[0xF] = (byte)(vxValue > vyValue  ? 1 : 0);
            core.Registers[vx] = (byte)(vxValue - vyValue);

            core.IncrementPC();
        }
    }
}
