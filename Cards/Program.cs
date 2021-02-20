using System;
using System.Collections.Generic;
using System.Linq;
using Combinatorics.Collections;

namespace Cards
{
	public static class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				int[] cards = GetUserCards();
				int score = FindGroups(cards, 2);
				score += NumberOfSums(cards, 15);
				Console.WriteLine(score);
			}

		}

		public static int NumberOfSums(int[] numbers, int goal)
		{
			int sums = 0;
			for (int i = 1; i <= numbers.Length; i++)
			{
				var combinations = new Combinations<int>(numbers, i);
				foreach (var combination in combinations)
				{
					if (combination.Sum() == goal)
					{
						sums++;
					}
				}
			}

			return sums;
		}

		public static int FindGroups(int[] cards, int groupSize)
		{
			var cardFrequencyTable = CountCardFrequency(cards);
			var pairCount = 0;
			foreach (var frequency in cardFrequencyTable.Values)
			{
				// nCr = n! / r! * (n - r)!
				pairCount += Factorial(frequency) /
					(Factorial(groupSize) * Factorial(frequency - groupSize));
			}

			return pairCount;
		}
		
		private static int Factorial(int i)
		{
			if (i <= 1)
			{
				return 1;
			}

			return i * Factorial(i - 1);
		}

		public static Dictionary<int,int> CountCardFrequency(int[] cards)
		{
			Dictionary<int, int> CardFrequency = new Dictionary<int, int>();
			foreach (var card in cards)
			{
				if (CardFrequency.ContainsKey(card))
				{
					CardFrequency[card]++;
				}
				else
				{
					CardFrequency.Add(card, 1);
				}
			}

			return CardFrequency;
		}

		private static int[] GetUserCards()
		{
			Console.WriteLine("Enter your cards seperated by spaces");
			string rawInput = Console.ReadLine();
			string[] rawCards = rawInput.Split(' ', StringSplitOptions.TrimEntries);
			int[] cards = new int[rawCards.Length];
			for (int i = 0; i < rawCards.Length; i++)
			{
				cards[i] = Convert.ToInt32(rawCards[i]);
			}

			return cards;
		}
	}
}