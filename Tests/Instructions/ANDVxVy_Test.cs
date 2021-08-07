using Chip8.Emulator.Instructions;
using Chip8.Emulator.Instructions.Implementation;
using NUnit.Framework;

namespace Chip8.Tests.Instructions
{
    [TestFixture]
    class ANDVxVy_Test : InstructionTestBase
    {
        [TestCase(0x8102, 0x00, 0x01)]
        [TestCase(0x8652, 0x04, 0x06)]
        [TestCase(0x8282, 0xFF, 0x01)]
        public void ANDVxVy_Execute_Test(int opcodeValue, int vxValue, int vyValue)
        {
            ushort ushortOpcode = (ushort)opcodeValue;

            byte vx = GetVx(ushortOpcode);
            TestCore.Registers[vx] = (byte)vxValue;

            byte vy = GetVy(ushortOpcode);
            TestCore.Registers[vy] = (byte)vyValue;

            ANDVxVy instruction = new ANDVxVy();
            instruction.Execute(TestCore, new Opcode(ushortOpcode));

            Assert.That(TestCore.Registers[vx] == (byte)(vxValue & vyValue));
            Assert.That(TestCore.PC == 2);
        }
    }
}
