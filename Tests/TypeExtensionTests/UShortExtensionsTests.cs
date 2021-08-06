using Chip8.Emulator.Extensions;
using NUnit.Framework;
using System;

namespace Chip8.Tests.TypeExtensionTests
{
    class UShortExtensionsTests
    {
        [Test]
        public void GetNibblesTest()
        {
            TestAllUShortValues( x => {
                byte[] nibbles = x.GetNibbles();
                Assert.IsTrue(nibbles.Length == 4);
                Assert.IsTrue(nibbles[0] == (byte)(x >> 12));
                Assert.IsTrue(nibbles[1] == (byte)((x >> 8) & 0x0F));
                Assert.IsTrue(nibbles[2] == (byte)((x >> 4) & 0x0F));
                Assert.IsTrue(nibbles[3] == (byte)(x & 0x0F));
            });
        }

        [Test]
        public void GetLeftByteTest()
        {
            TestAllUShortValues( x => {
                byte leftByte = x.GetLeftByte();              
                Assert.IsTrue(leftByte == (byte)(x >> 8));
            });   
        }

        [Test]
        public void GetRightByteTest()
        {
            TestAllUShortValues(x => {
                byte rightByte = x.GetRightByte();
                Assert.IsTrue(rightByte == (byte)(x & 0x00FF));
            });
        }

        [Test]
        public void GetNibbleTest()
        {
            ushort value = 0x1234;
            Assert.IsTrue(value.GetNibble(0) == 0x01);
            Assert.IsTrue(value.GetNibble(1) == 0x02);
            Assert.IsTrue(value.GetNibble(2) == 0x03);
            Assert.IsTrue(value.GetNibble(3) == 0x04);
        }

        public void TestAllUShortValues(Action<ushort> testAction)
        {
            for (ushort i = ushort.MinValue; i < ushort.MaxValue; i++)
                testAction(i);
        }

    }
}
