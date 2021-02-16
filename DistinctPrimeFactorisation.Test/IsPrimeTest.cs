using DistinctPrimeFactoisation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistinctPrimeFactorisation.Test
{
    public class IsPrimeTest
    {
        [TestCase(5, true)]
        [TestCase(7, true)]
        [TestCase(9, false)]
        [TestCase(15, false)]
        [TestCase(4, false)]
        public void IsPrime(int input, bool result)
        {
            Assert.AreEqual(result, Program.IsPrime(input));
        }
    }
}
