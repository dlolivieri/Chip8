using Chip8.Emulator.Instructions;
using Chip8.Emulator.Instructions.Implementation;
using NUnit.Framework;

namespace Chip8.Tests.Instructions
{
    [TestFixture]
    class CALL_Test : InstructionTestBase
    {
        [TestCase(0x2123, 0xFFFF)]
        [TestCase(0x2456, 0x1234)]
        public void CALL_Execute_Test(int opcode, int initialPC)
        {
            ushort ushortOpcode = (ushort)opcode;
            ushort nnn = GetNNN(ushortOpcode);
            TestCore.PC = (ushort)initialPC;

            CALL instruction = new CALL();
            instruction.Execute(TestCore, new Opcode(ushortOpcode));

            Assert.IsTrue(TestCore.SP == 1);
            Assert.IsTrue(TestCore.Stack.Peek() == initialPC);
            Assert.IsTrue(TestCore.PC == nnn);
        }
    }
}
