﻿using Chip8.Emulator.Cpu;
using System;

namespace Chip8.Emulator.Instructions.Implementation
{
    class ADDVx : IInstruction
    {
        /// <summary>
        /// 7xkk - ADD Vx, byte
        /// Set Vx = Vx + kk.
        /// Adds the value kk to the value of register Vx, then stores the result in Vx.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            if (core == null) throw new ArgumentNullException("core");
            if (opcode == null) throw new ArgumentNullException("opcode");

            byte vx = opcode.GetNibble(1);
            byte kk = opcode.RightByte;
            //TODO: What happens if the addition overflows the byte?
            core.Registers[vx] += kk;
            core.IncrementPC();
        }
    }
}