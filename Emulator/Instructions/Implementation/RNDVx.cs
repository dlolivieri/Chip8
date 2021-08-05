using Chip8.Emulator.Cpu;
using System;

namespace Chip8.Emulator.Instructions.Implementation
{
    public class RndVx : IInstruction
    {
        /// <summary>
        /// Cxkk - RND Vx, byte
        /// Set Vx = random byte AND kk.
        /// The interpreter generates a random number from 0 to 255, which is then ANDed with the value kk. The results are stored in Vx.
        /// </summary>
        public void Execute(IChip8Core core, IOpcode opcode)
        {
            int randomNumber = new Random().Next(byte.MaxValue);
            Execute(core, opcode, (byte)randomNumber);          
        }

        /// <summary>
        /// Cxkk - RND Vx, byte
        /// Set Vx = random byte AND kk.
        /// For testing purposes. Pass in a hardcoded "random" number.
        /// </summary>
        /// <param name="randomNumber">Number to & with NN</param>
        public void Execute(IChip8Core core, IOpcode opcode, byte randomNumber)
        {
            byte vx = opcode.GetNibble(1);
            byte kk = opcode.RightByte;
            core.Registers[vx] = (byte)(randomNumber & kk);
            core.IncrementPC();
        }
    }
}
