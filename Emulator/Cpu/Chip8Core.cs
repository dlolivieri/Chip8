using Chip8.Emulator.Instructions;
using Chip8.Emulator.Instructions.Implementation;
using System;

namespace Chip8.Emulator.Cpu
{
    public class Chip8Core : IChip8Core
    {
        public IChip8Memory Memory { get; } = new Chip8Memory();
        public IChip8Registers Registers { get; } = new Chip8Registers();

        public IChip8Stack Stack { get; } = new Chip8Stack();

        public IChip8InstructionSet InstructionSet { get; } = new Chip8InstructionSet();

        public ushort PC { get; set; } = 0;

        public byte SP { get; set; } = 0;

        public Chip8Core()
        {       
        }

        public void IncrementPC()
        {
            PC += 2;
        }

        public IOpcode Fetch(ushort opcodeBits)
        {
            return new Opcode(opcodeBits);
        }

        public IInstruction Decode(IOpcode opcode)
        {
            return InstructionSet.GetInstruction(opcode);
        }

        public void Execute(IInstruction instruction, IOpcode opcode)
        {
            instruction.Execute(this, opcode);
        }

        public void Step()
        {
            IOpcode opcode = Fetch(Memory.Read16(PC));
            IInstruction instruction = Decode(opcode);
            Execute(instruction, opcode);
        }     
    }
}
