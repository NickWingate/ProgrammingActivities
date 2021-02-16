using DistinctPrimeFactoisation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistinctPrimeFactorisation.Test
{
    public class SumTest
    {
        [TestCase(new int[2] { 1, 2 }, 3)]
        [TestCase(new int[2] { 50, 23 }, 73)]
        [TestCase(new int[2] { -1, -3 }, -4)]
        [TestCase(new int[2] { 50, -20 }, 30)]
        public void SumTwoNumbers(int[] input, int result)
        {
            Assert.AreEqual(result, Program.Sum(input));
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 10)]
        [TestCase(new int[] { 4, 3, 1, 2 }, 10)]
        [TestCase(new int[] { 10, -50, 2, 37 }, -1)]
        public void SumSeveralNumbers(int[] input, int result)
        {
            Assert.AreEqual(result, Program.Sum(input));
        }
    }
}
