using Chip8.Emulator.Extensions;
using NUnit.Framework;
using System;

namespace Chip8.Tests.TypeExtensionTests
{
    class ByteExtensions_Test
    {
        [Test]
        public void GetNibbles_Test()
        {
            for (byte i = byte.MinValue; i < byte.MaxValue; i++)
            {
                byte[] nibbles = i.GetNibbles();
                Assert.IsTrue(nibbles[0] == (byte)(i >> 4));
                Assert.IsTrue(nibbles[1] == (byte)(i & 0x0F));
            }
        }

        [TestCase(0, ExpectedResult = 0x0102)]
        [TestCase(1, ExpectedResult = 0x0203)]
        [TestCase(2, ExpectedResult = 0x0304)]
        [TestCase(3, ExpectedResult = 0x0405)]
        [TestCase(4, ExpectedResult = 0x0506)]
        public ushort Read16_Test(int index)
        {
            byte[] bytes = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06 };
            return bytes.Read16(index);
        }

        [TestCase(-1)]
        [TestCase(5)]
        [TestCase(6)]
        public void Read16_Throws_Test(int index)
        {
            byte[] bytes = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06 };
            Assert.That(() => bytes.Read16(index), Throws.TypeOf<IndexOutOfRangeException>());
        }

        [TestCase(0, 0x1111)]
        [TestCase(1, 0xAF14)]
        [TestCase(2, 0xFFFF)]
        public void Write16_Test(int index, int value)
        {
            byte[] bytes = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            bytes.Write16(index, (ushort)value);

            Assert.IsTrue(bytes[index] == (value & 0xFF00) >> 8);
            Assert.IsTrue(bytes[index + 1] == (value & 0x00FF));
        }


        [TestCase(-1, 0x000)]
        [TestCase(5, 0x000)]
        [TestCase(6, 0x000)]
        public void Write16_Throws_Test(int index, int value)
        {
            byte[] bytes = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            Assert.That(() => bytes.Write16(index, (ushort)value), Throws.TypeOf<IndexOutOfRangeException>());
        }
    }
}
