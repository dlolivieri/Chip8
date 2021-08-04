using Chip8.Emulator.Cpu;
using System;

namespace Chip8.Emulator.Instructions
{
    /// <summary>
    /// The original implementation of the Chip-8 language includes 36 different instructions, including math, graphics, and flow control functions.
    /// All instructions are 2 bytes long and are stored most-significant-byte first. In memory, the first byte of each instruction should be located at an even addresses. 
    /// If a program includes sprite data, it should be padded so any instructions following it will be properly situated in RAM.
    /// nnn or addr - A 12-bit value, the lowest 12 bits of the instruction
    /// n or nibble - A 4-bit value, the lowest 4 bits of the instruction
    /// x - A 4-bit value, the lower 4 bits of the high byte of the instruction
    /// y - A 4-bit value, the upper 4 bits of the low byte of the instruction
    /// kk or byte - An 8-bit value, the lowest 8 bits of the instruction
    /// </summary>
    public interface IInstruction
    {   
        /// <summary>
        /// Execute the instruction
        /// </summary>
        /// <param name="core">Core to perform the instruction on</param>
        /// <param name="opcode">Opcode object representing the opcode value</param>
        public void Execute(IChip8Core core, IOpcode opcode);
    }
}
