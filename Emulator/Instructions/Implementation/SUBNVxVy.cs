using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    class SUBNVxVy : IInstruction
    {
        /// <summary>
        /// 8xy7 - SUBN Vx, Vy
        /// Set Vx = Vy - Vx, set VF = NOT borrow.
        /// If Vy > Vx, then VF is set to 1, otherwise 0. Then Vx is subtracted from Vy, and the results stored in Vx.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            byte vx = opcode.X;
            byte vxValue = core.Registers[vx];

            byte vy = opcode.Y;         
            byte vyValue = core.Registers[vy];

            core.Registers[0xF] = (byte)(vyValue > vxValue ? 1 : 0);
            core.Registers[vx] = (byte)(vyValue - vxValue);

            core.IncrementPC();
        }
    }
}
