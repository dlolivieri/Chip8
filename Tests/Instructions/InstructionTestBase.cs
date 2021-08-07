using Chip8.Emulator.Cpu;
using NUnit.Framework;

namespace Chip8.Tests.Instructions
{
    [TestFixture]
    class InstructionTestBase
    {

        protected Chip8Core TestCore;

        [SetUp]
        public void Setup()
        {
            TestCore = new Chip8Core();
        }

        protected byte GetVx(ushort opcode)
        {
            return (byte)((opcode >> 8) & 0x000F);
        }

        protected byte GetVy(ushort opcode)
        {
            return (byte)((opcode >> 4) & 0x000F);
        }

        protected byte GetKK(ushort opcode)
        {
            return (byte)(opcode & 0x00FF);
        }

        protected ushort GetNNN(ushort opcode)
        {
            return (ushort)(opcode & 0x0FFF);
        }
    }
}
