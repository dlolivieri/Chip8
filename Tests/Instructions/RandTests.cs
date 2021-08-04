using NUnit.Framework;
using Chip8.Emulator.Instructions.Implementation;
using Chip8.Emulator.Instructions;

namespace Chip8.Tests.Instructions
{
    class RandTests : InstructionTestBase
    {
        [Test]
        [TestCase(0xC0FF, 0x0, 0xFF, 0xFF)]
        public void Rand(int opcodeValue, int expectedRegister, int randomNumber, int expectedValue)
        {
            RndVx instruction = new RndVx();
            IOpcode opcode = new Opcode((ushort)opcodeValue);

            instruction.Execute(TestCore, opcode, (byte)randomNumber);

            Assert.IsTrue(TestCore.Registers[expectedRegister] == 0xFF);
        }
    }
}
