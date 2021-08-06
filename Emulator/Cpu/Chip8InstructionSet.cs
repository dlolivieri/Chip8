using Chip8.Emulator.Instructions;
using Chip8.Emulator.Instructions.Implementation;
using System;
using System.Collections.Generic;

namespace Chip8.Emulator.Cpu
{
    public class Chip8InstructionSet : IChip8InstructionSet
    {
        public IInstruction GetInstruction(IOpcode opcode)
        {
            byte id = opcode.InstructionId;
            ushort code = opcode.Code;

            return (id) switch 
            { 
                0x0 when code == 0x00E0 => new CLS(),
                0x0 when code == 0x00EE => new RET(),
                0x1 => new JP(),
                0x2 => new CALL(),
                0x3 => new SEVx(),
                0x4 => new SNEVx(),
                0x5 => new SEVxVy(),
                0x6 => new LDVx(),
                0x7 => new ADDVx(),
                0x8 when (code & 0x000F) == 0x0 => new LDVxVy(),
                0x8 when (code & 0x000F) == 0x1 => new ORVxVy(),
                0x8 when (code & 0x000F) == 0x2 => new ANDVxVy(),
                0x8 when (code & 0x000F) == 0x3 => new XORVxVy(),
                0x8 when (code & 0x000F) == 0x4 => new ADDVxVy(),
                0x8 when (code & 0x000F) == 0x5 => new SUBVxVy(),
                0x8 when (code & 0x000F) == 0x6 => new SHRVxVy(),
                0x8 when (code & 0x000F) == 0x7 => new SUBNVxVy(),
                0x8 when (code & 0x000F) == 0xE => new SHLVxVy(),
                0x9 => new SNEVxVy(),
                0xA => new LDI(),
                0xB => new JPV0(),
                0xC => new RndVx(),
                0xD => new DRWVxVy(),
                0xE when (code & 0x00FF) == 0x9E => new SKPVx(),
                0xE when (code & 0x00FF) == 0xA1 => new SKNPVx(),
                0xF when (code & 0x00FF) == 0x07 => new LDVxDT(),
                0xF when (code & 0x00FF) == 0x0A => new LDVxK(),
                0xF when (code & 0x00FF) == 0x15 => new LDDTVx(),
                0xF when (code & 0x00FF) == 0x18 => new LDSTVx(),
                0xF when (code & 0x00FF) == 0x1E => new ADDIVx(),
                0xF when (code & 0x00FF) == 0x29 => new LDFVx(),
                0xF when (code & 0x00FF) == 0x33 => new LDBVx(),
                0xF when (code & 0x00FF) == 0x55 => new LDIVx(),
                0xF when (code & 0x00FF) == 0x65 => new LDVxI(),
                _ => throw new NotImplementedException()        
            };
        }
    }
}
