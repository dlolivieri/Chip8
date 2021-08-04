using Chip8.Emulator.Instructions;

namespace Chip8.Emulator.Cpu
{
    public interface IChip8InstructionSet
    {
        IInstruction GetInstruction(IOpcode opcode);
    }
}
