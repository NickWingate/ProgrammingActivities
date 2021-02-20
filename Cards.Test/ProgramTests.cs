using System.Collections.Generic;
using NUnit.Framework;

namespace Cards.Test
{
	public class ProgramTests
	{
		[Test]
		public void CountCardFrequency_ShouldCountFrequency_WhenInputValid()
		{
			// Arrange
			var cards = new int[] { 1, 1, 3, 5, 6 };
			var expected = new Dictionary<int, int>()
			{
				{1, 2},
				{3, 1},
				{5, 1},
				{6, 1},
			};
			// Act

			// Assert
			Assert.AreEqual(expected, Program.CountCardFrequency(cards));
		}

		[TestCase(new int[] {1, 1}, 1)]
		[TestCase(new int[] {1, 1, 1}, 3)]
		[TestCase(new int[] {1, 1, 1, 2, 2}, 4)]
		[TestCase(new int[] {1, 2, 1, 2, 1}, 4)]
		[TestCase(new int[] {1, 2, 1, 2, 3}, 2)]
		[TestCase(new int[] {5, 5, 10, 5, 5}, 6)]
		public void FindGroups_ShouldCountPossiblePairs_WhenInputValid(int[] cards, int result)
		{
			Assert.AreEqual(result, Program.FindGroups(cards, 2));
		}

		[TestCase(new int[] { 1, 1 }, 2, 1)]
		[TestCase(new int[] { 1, 1 }, 1, 2)]
		[TestCase(new int[] { 1, 1, 2, 6 }, 10, 1)]
		public void NumberOfSums_ShouldReturnNumberOfWaysToMeetGoal(
			int[] numbersInput, int goalInput, int expectedResult)
		{
			Assert.AreEqual(expectedResult, 
				Program.NumberOfSums(numbersInput, goalInput));
		}
	}
}