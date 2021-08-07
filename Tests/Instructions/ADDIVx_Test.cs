using Chip8.Emulator.Instructions;
using Chip8.Emulator.Instructions.Implementation;
using NUnit.Framework;

namespace Chip8.Tests.Instructions
{
    [TestFixture]
    class ADDIVx_Test : InstructionTestBase
    {
        [Test]
        [TestCase(0xF11E, 0x00, 0x03)]
        [TestCase(0xF11E, 0x01, 0x04)]
        [TestCase(0xF11F, 0x02, 0x05)]
        public void ADDIVx_Execute_Test(int opcodeValue, int initialIValue, int expectedResult)
        {
            TestCore.Registers.I = (ushort)initialIValue;
            TestCore.Registers[1] = 0x03;

            ADDIVx instruction = new ADDIVx();
            instruction.Execute(TestCore, new Opcode((ushort)opcodeValue));

            Assert.That(TestCore.Registers.I == expectedResult);
            Assert.That(TestCore.PC == 2); 
        }
    }
}
