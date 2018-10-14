using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitInserter.Tests
{
    [TestClass]
    public class InsertNumberTests
    {
        [TestMethod]
        public void InsertNumberMethod_CorrectData_ReturnNewIntegerNumber()
        {
            int expectedNumber = 120;

            int actNumber = Inserter.InsertNumber(8, 15, 3, 8);

            Assert.AreEqual(expectedNumber, actNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumberMethod_FirstIndBiggerThanSecondInd_ArgumentOutOfRangeException()
        {
            Inserter.InsertNumber(8,15,10,5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumberMethod_IndexArgsLowerThanZero_ArgumentOutOfRangeException()
        {
            Inserter.InsertNumber(8, 15, -1, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumberMethod_IndexArgsBiggerThanRange_ArgumentOutOfRangeException()
        {
            Inserter.InsertNumber(8, 15, 32, 32);
        }
    }
}
