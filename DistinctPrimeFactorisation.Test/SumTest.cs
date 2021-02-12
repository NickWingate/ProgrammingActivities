using DistinctPrimeFactoisation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistinctPrimeFactorisation.Test
{
    public class SumTest
    {
        [Test]
        public void SumTwoNumbers()
        {
            Assert.AreEqual(3, Program.Sum(new List<int> { 1, 2 }));
        }
    }
}
