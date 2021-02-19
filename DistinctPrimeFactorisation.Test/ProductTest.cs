using System.Collections.Generic;
using NUnit.Framework;

namespace DistinctPrimeFactorisation.Test
{
	public class ProductTest
	{
		[TestCase(0)]
		[TestCase(1)]
		[TestCase(20)]
		[TestCase(161)]
		[TestCase(200)]
		public void Product_ShouldReturnInput_WhenOneNumberInput(int number)
		{
			Assert.AreEqual(number, Program.Product(new List<int>{number}));
		}

		[TestCase(new int[] { 1, 3, 10, 5}, 150)]
		[TestCase(new int[] { 6, 2, 3, 4}, 144)]
		public void Product_ShouldMultiplyAll_WhenInputValid(int[] input, int result)
		{
			Assert.AreEqual(result, Program.Product(input));
		}

	}
}