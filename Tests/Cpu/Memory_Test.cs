using Chip8.Emulator.Cpu;
using NUnit.Framework;
using System;
using System.Linq;

namespace Chip8.Tests.Cpu
{
    class Memory_Test
    {
        IChip8Memory TestMemory;

        [SetUp]
        public void Setup()
        {
            byte[] testMemorySpace = new byte[Chip8Memory.MEMORY_SIZE];

            for (int i = 0; i < testMemorySpace.Length; i++)
                testMemorySpace[i] = (byte)(i % byte.MaxValue);

            TestMemory = new Chip8Memory(testMemorySpace);
        }

        [Test]
        public void Read8_Test()
        {
            for (int i = 0; i < TestMemory.MemorySpace.Length; i++)
                Assert.That(TestMemory.Read8(i) == i % byte.MaxValue);
        }

        [Test]
        public void Read16_Test()
        {
            Func<int, ushort> TestGetShort = (index) => (ushort)(TestMemory.MemorySpace[index] << 8 | TestMemory.MemorySpace[index + 1]);

            for (int i = 0; i < TestMemory.MemorySpace.Length - 1; i++)
                Assert.That(TestMemory.Read16(i) == TestGetShort(i));
        }

        [Test]
        public void Write8_Test()
        {
            for (int i = 0; i < TestMemory.MemorySpace.Length; i++)
            {
                TestMemory.Write8(i, (byte)(i % byte.MaxValue));
                Assert.That(TestMemory.MemorySpace[i] == i % byte.MaxValue);
            }
        }

        [Test]
        public void Write16_Test()
        {
            Func <int, ushort> TestRead16 = (index) => (ushort)(TestMemory.MemorySpace[index] << 8 | TestMemory.MemorySpace[index + 1]);

            for (int i = 0; i < TestMemory.MemorySpace.Length - 1; i++)
            {
                TestMemory.Write16(i, (byte)(i % byte.MaxValue));
                Assert.That(TestMemory.Read16(i) == TestRead16(i));
            }
        }
    }
}
