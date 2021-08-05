using Chip8.Emulator.Cpu;

namespace Chip8.Emulator.Instructions.Implementation
{
    class CALL : IInstruction
    {
        /// <summary>
        /// 2nnn - CALL addr
        /// Call subroutine at nnn.
        /// The interpreter increments the stack pointer, then puts the current PC on the top of the stack. The PC is then set to nnn.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            core.SP++;
            core.Stack.Push(core.PC);
            ushort nnn = opcode.NNN;
            core.PC = nnn;       
        }
    }
}
