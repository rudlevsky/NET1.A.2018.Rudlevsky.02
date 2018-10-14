using System;
using NUnit.Framework;

namespace BitInserter.Tests
{
    [TestFixture]
    public class InsertNumberNTests
    {
        [TestCase(8, 15, 3, 8,ExpectedResult = 120)]
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        public int InsertNumberMethod_CorrectData_ReturnNewIntegerNumber(int firstNum, int secondNum, int firstInd, int secondInd)
        {
            return Inserter.InsertNumber(firstNum, secondNum, firstInd, secondInd);
        }

        [Test]
        public void InsertNumberMethod_FirstIndBiggerThanSecondInd_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Inserter.InsertNumber(8, 15, 10, 5));
        }

        [Test]
        public void InsertNumberMethod_IndexArgsLowerThanZero_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Inserter.InsertNumber(8, 15, -1, -1));
        }

        [Test]
        public void InsertNumberMethod_IndexArgsBiggerThanRange_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Inserter.InsertNumber(8, 15, 32, 32));
        }
    }
}
