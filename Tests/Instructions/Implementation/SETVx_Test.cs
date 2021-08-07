using Chip8.Emulator.Instructions;
using Chip8.Emulator.Instructions.Implementation;
using NUnit.Framework;

namespace Chip8.Tests.Instructions.Implementation
{
    [TestFixture]
    class SetVx_Test : InstructionTestBase
    {
        [Test]
        [TestCase(0x6101, 0x01, 0x01)]
        [TestCase(0x62FF, 0x02, 0xFF)]
        [TestCase(0x63F3, 0x03, 0xF3)]
        public void SetVx_Execute_Test(int opcodeValue, int expectedRegister, int expectedValue)
        {
            TestVx(opcodeValue, expectedRegister, expectedValue, 2);
        }

        [Test]
        public void SetAllVx_Test()
        {
            int expectedPC = 0;
            for(int i = 0; i < TestCore.Registers.RegisterCount; i++)
            {
                for (int j = 0; j <= byte.MaxValue; j++)
                {
                    int opcodeValue = (0x6 << 12) | (i << 8) | j;
                    int expectedRegister = i;
                    int expectedValue = j;

                    TestVx(opcodeValue, expectedRegister, expectedValue, expectedPC += 2);
                }
            }      
        }

        public void TestVx(int opcodeValue, int expectedRegister, int expectedValue, int expectedPC)
        {
            ushort ushortOpcode = (ushort)opcodeValue;
            Opcode opcode = new Opcode(ushortOpcode);

            IInstruction instruction = new LDVx();
            instruction.Execute(TestCore, opcode);

            Assert.IsTrue(TestCore.Registers[expectedRegister] == (byte)expectedValue);
            Assert.IsTrue(TestCore.PC == expectedPC);
        }
   
    }
}
