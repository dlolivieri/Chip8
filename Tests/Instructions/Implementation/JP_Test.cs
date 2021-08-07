using Chip8.Emulator.Instructions;
using Chip8.Emulator.Instructions.Implementation;
using NUnit.Framework;

namespace Chip8.Tests.Instructions.Implementation
{
    [TestFixture]
    class JP_Test : InstructionTestBase
    {
        [TestCase(0x1123)]
        [TestCase(0x1456)]
        public void JP_Execute_Test(int opcode)
        {
            ushort ushortOpcode = (ushort)opcode;
            ushort nnn = GetNNN(ushortOpcode);

            JP instruction = new JP();
            instruction.Execute(TestCore, new Opcode(ushortOpcode));

            Assert.IsTrue(TestCore.PC == nnn);
        }
    }
}
