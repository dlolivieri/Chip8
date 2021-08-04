﻿using Chip8.Emulator.Cpu;
using System;

namespace Chip8.Emulator.Instructions.Implementation
{
    class XORVxVy : IInstruction
    {
        /// <summary>
        /// 8xy3 - XOR Vx, Vy
        /// Set Vx = Vx XOR Vy.
        /// Performs a bitwise exclusive OR on the values of Vx and Vy, then stores the result in Vx.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            throw new NotImplementedException();
        }
    }
}
