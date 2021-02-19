using DistinctPrimeFactorisation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistinctPrimeFactorisation.Test
{
    public class FindPrimeFactorsTest
    {
        [TestCase(48, new int[] { 2,2,2,2,3 })]
        [TestCase(100, new int[] { 2,2,5,5 })]
        [TestCase(32, new int[] { 2,2,2,2,2 })]
        [TestCase(123, new int[] { 3,41 })]
        public void FindPrimeFactors(int input, int[] result)
        {
            Assert.AreEqual(new List<int>(result), Program.FindPrimeFactors(input));
        }
    }
}
