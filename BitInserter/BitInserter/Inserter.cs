using System;

namespace BitInserter
{
    /// <summary>
    /// Class contains method for inserting bits.
    /// </summary>
    public static class Inserter
    {
        /// <summary>
        /// Check all rules and return the result.
        /// </summary>
        /// <param name="firstNum">Number for inserting bits.</param>
        /// <param name="secondNum">Number for taking bits.</param>
        /// <param name="firstInd">Index from which bits will be taken.</param>
        /// <param name="secondInd">End index of taking bits.</param>
        /// <returns>New integer after inserting bits.</returns>
        public static int InsertNumber(int firstNum, int secondNum, int firstInd, int secondInd)
        {
            const int IntLength = 31;

            if (firstInd > secondInd)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (secondInd < 0 || firstInd < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (firstInd > IntLength || secondInd > IntLength)
            {
                throw new ArgumentOutOfRangeException();
            }

            return InsertBits(firstNum, secondNum, firstInd, secondInd);
        }

        /// <summary>
        /// Insert bits from the second to the first number.
        /// </summary>
        /// <param name="firstNum">Number for inserting bits.</param>
        /// <param name="secondNum">Number for taking bits.</param>
        /// <param name="firstInd">Index from which bits will be taken.</param>
        /// <param name="secondInd">End index of taking bits.</param>
        /// <returns>New integer after inserting bits.</returns>
        private static int InsertBits(int firstNum, int secondNum, int firstInd, int secondInd)
        {
            const int IntLength = 31;

            int slider = secondInd - firstInd + 1;
            int box = int.MaxValue >> (IntLength - slider);

            firstNum &= ~(box << firstInd);
            box = (box & secondNum) << firstInd;

            return box | firstNum;
        }
    }
}
