﻿using Chip8.Emulator.Cpu;
using System;

namespace Chip8.Emulator.Instructions.Implementation
{
    class SHLVxVy : IInstruction
    {
        /// <summary>
        /// 8xyE - SHL Vx {, Vy }
        /// Set Vx = Vx SHL 1.
        /// If the most-significant bit of Vx is 1, then VF is set to 1, otherwise to 0. Then Vx is multiplied by 2.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            throw new NotImplementedException();
        }
    }
}