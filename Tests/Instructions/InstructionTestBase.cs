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
    }
}
