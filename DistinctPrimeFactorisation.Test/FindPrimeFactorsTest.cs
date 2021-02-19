using DistinctPrimeFactorisation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DistinctPrimeFactorisation.Test
{
    public class FindPrimeFactorsTest
    {
        [TestCase(48, new int[] { 2,2,2,2,3 })]
        [TestCase(100, new int[] { 2,2,5,5 })]
        [TestCase(32, new int[] { 2,2,2,2,2 })]
        [TestCase(123, new int[] { 3,41 })]
        public void FindPrimeFactors_ShouldFindPrimeFactors_WhenValidInput(int input, int[] result)
        {
            Assert.AreEqual(new List<int>(result), Program.FindPrimeFactors(input));
        }

        [TestCase(3)]
        [TestCase(5)]
        [TestCase(41)]
        [TestCase(23)]
        public void FindPrimeFactors_ShouldReturnInput_WhenInputPrime(int prime)
        {
            Assert.AreEqual(new List<int>{ prime }, Program.FindPrimeFactors(prime));
        }
        
    }
}
