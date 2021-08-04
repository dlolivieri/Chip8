using Chip8.Emulator.Cpu;
using System;

namespace Chip8.Emulator.Instructions.Implementation
{
    class DRWVxVy : IInstruction
    {
        /// <summary>
        /// Dxyn - DRW Vx, Vy, nibble
        /// Display n-byte sprite starting at memory location I at(Vx, Vy), set VF = collision.
        /// The interpreter reads n bytes from memory, starting at the address stored in I.
        /// These bytes are then displayed as sprites on screen at coordinates(Vx, Vy). 
        /// Sprites are XORed onto the existing screen.
        /// If this causes any pixels to be erased, VF is set to 1, otherwise it is set to 0. 
        /// If the sprite is positioned so part of it is outside the coordinates of the display, it wraps around to the opposite side of the screen.
        /// </summary>
        /// <param name="core"></param>
        /// <param name="opcode"></param>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            throw new NotImplementedException();
        }
    }
}
