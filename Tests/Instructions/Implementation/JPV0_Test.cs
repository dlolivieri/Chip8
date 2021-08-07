using Chip8.Emulator.Instructions;
using Chip8.Emulator.Instructions.Implementation;
using NUnit.Framework;

namespace Chip8.Tests.Instructions.Implementation
{
    [TestFixture]
    class JPV0_Test : InstructionTestBase
    {
        [TestCase(0xB123, 0x01)]
        [TestCase(0xB456, 0xFF)]
        public void JP_Execute_Test(int opcode, int initialV0)
        {
            ushort ushortOpcode = (ushort)opcode;
            ushort nnn = GetNNN(ushortOpcode);

            TestCore.Registers[0] = (byte)initialV0;

            JPV0 instruction = new JPV0();
            instruction.Execute(TestCore, new Opcode(ushortOpcode));

            Assert.IsTrue(TestCore.PC == nnn + initialV0);
        }
    }
}
