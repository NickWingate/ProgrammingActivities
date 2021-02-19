using DistinctPrimeFactorisation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistinctPrimeFactorisation.Test
{
    public class RemoveDuplicatesTest
    {
        [Test]
        public void SingleItemList()
        {
            List<int> expected = new List<int> { 0 };
            List<int> actual = Program.RemoveDuplicates(new List<int> { 0, 0, 0 });
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void OneLengthList()
        {
            List<int> expected = new List<int> { 0 };
            List<int> actual = Program.RemoveDuplicates(new List<int> { 0 });
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EmptyList()
        {
            List<int> expected = new List<int> {  };
            List<int> actual = Program.RemoveDuplicates(new List<int> {  });
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1,2,1,3,3,1,5,2,10,20 }, new int[] { 1,2,3,5,10,20})]
        [TestCase(new int[] { 1,1,1,3,1000,60,1,23,32,2333 }, new int[] { 1,3,1000,60,23,32,2333})]
        public void ComplexList(int[] input, int[] result)
        {
            List<int> expected = new List<int>(result);
            List<int> actual = Program.RemoveDuplicates(new List<int>(input));
            Assert.AreEqual(expected, actual);
        }


    }
}
