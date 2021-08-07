using Chip8.Emulator.Instructions;
using Chip8.Emulator.Instructions.Implementation;
using NUnit.Framework;

namespace Chip8.Tests.Instructions
{
    class ADDVx_Test
    {
        class ADDIVx_Test : InstructionTestBase
        {
            [TestCase(0x7100, 0x00)]
            [TestCase(0x7288, 0x01)]
            //[TestCase(0x73FF, 0x02)] //TODO test overflow condition
            public void ADDIVx_Execute_Test(int opcodeValue, int vxValue)
            {
                ushort ushortOpcode = (ushort)opcodeValue;
                byte vx = GetVx(ushortOpcode);
                byte kk = GetKK(ushortOpcode);

                TestCore.Registers[vx] = (byte)vxValue;

                ADDVx instruction = new ADDVx();
                instruction.Execute(TestCore, new Opcode(ushortOpcode));
               
                Assert.That(TestCore.Registers[vx] == vxValue + kk);
                Assert.That(TestCore.PC == 2);
            }
        }
    }
}
