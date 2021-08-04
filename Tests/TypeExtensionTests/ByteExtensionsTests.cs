using NUnit.Framework;
using Chip8.Emulator.Extensions;

namespace Chip8.Tests.TypeExtensionTests
{
    class ByteExtensionsTests
    {
        [Test]
        public void GetNibblesTest()
        {
            for(byte i = byte.MinValue; i < byte.MaxValue; i++)
            {
                byte[] nibbles = i.GetNibbles();
                Assert.IsTrue(nibbles[0] == (byte)(i >> 4));
                Assert.IsTrue(nibbles[1] == (byte)(i & 0x0F));
            }
        }
    }
}
