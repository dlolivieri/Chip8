using Chip8.Emulator.Instructions;
using Chip8.Emulator.Instructions.Implementation;
using NUnit.Framework;

namespace Chip8.Tests.Instructions
{
    [TestFixture]
    class ADDVxVy_Test : InstructionTestBase
    {
        [TestCase(0x7100, 0x00, 0x01, 0x00)]
        [TestCase(0x7650, 0x04, 0x06, 0x00)]
        [TestCase(0x7288, 0xFF, 0x01, 0x01)]
        public void ADDVxVy_Execute_Test(int opcodeValue, int vxValue, int vyValue, int expectedV0)
        {
            ushort ushortOpcode = (ushort)opcodeValue;

            byte vx = GetVx(ushortOpcode);
            TestCore.Registers[vx] = (byte)vxValue;

            byte vy = GetVy(ushortOpcode);     
            TestCore.Registers[vy] = (byte)vyValue;

            ADDVxVy instruction = new ADDVxVy();
            instruction.Execute(TestCore, new Opcode(ushortOpcode));

            Assert.That(TestCore.Registers[vx] == (byte)((vxValue + vyValue) & 0xFF));
            Assert.That(TestCore.Registers[0xF] == expectedV0);
            Assert.That(TestCore.PC == 2);
        }
    }
}
