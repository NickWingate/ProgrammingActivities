using DistinctPrimeFactorisation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistinctPrimeFactorisation.Test
{
    public class FindFactorsTest
    {
        [Test]
        public void FactoriseFour()
        {
            Assert.AreEqual(new List<int>{ 2 }, Program.FindFactors(4));
        }

        [Test]
        public void FactoriseTwo()
        {
            Assert.AreEqual(new List<int>{ 2 }, Program.FindFactors(2));
        }

        [Test]
        public void FactoriseTen()
        {
            Assert.AreEqual(new List<int>{ 2, 5 }, Program.FindFactors(10));
        }

        [TestCase(20, new int[] { 2,4,5,10 })]
        [TestCase(12, new int[] { 2,3,4,6 })]
        [TestCase(100, new int[] { 2,4,5,10,20,25,50 })]
        public void FactoriseNumbersWithNonPrimeFactors(int input, int[] result)
        {
            Assert.AreEqual(new List<int>(result), Program.FindFactors(input));
        }
    }
}
