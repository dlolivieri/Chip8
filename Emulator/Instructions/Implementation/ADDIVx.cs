using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    public class ADDIVx : IInstruction
    {
        /// <summary>
        /// Fx1E - ADD I, Vx
        /// Set I = I + Vx.
        /// The values of I and Vx are added, and the results are stored in I.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode) 
        {
            byte vx = opcode.X;
            ushort i = core.Registers.I;
            //TODO: What happens if the addition overflows the byte?
            core.Registers.I += core.Registers[vx];
            core.IncrementPC();
        }
    }
}
