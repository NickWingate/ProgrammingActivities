using System;

namespace FibonacciLetters
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				(char firstChar, char secondChar, int indexToFind) = GetUserInput();
				switch (indexToFind)
				{
					case 1:
						Console.WriteLine(firstChar);
						break;
					case 2:
						Console.WriteLine(secondChar);
						break;
					default:
						char[] charSequence = GenerateCharSequence(firstChar, secondChar, indexToFind);
						Console.WriteLine(charSequence[indexToFind - 1]);
						Console.WriteLine($"{charSequence[indexToFind - 3]}{charSequence[indexToFind - 2]}{charSequence[indexToFind - 1]}");
						Console.WriteLine(string.Join(", ", charSequence));
						break;
				}
			}
			

			

		}

		private static char[] GenerateCharSequence(char firstChar, char secondChar, int length)
		{
			char[] charSequence = new char[length];
			charSequence[0] = firstChar;
			charSequence[1] = secondChar;
			
			for (int i = 2; i < charSequence.Length; i++)
			{
				charSequence[i] = AddChars(charSequence[i - 2], charSequence[i - 1]);
			}

			return charSequence;
		}

		private static char AddChars(char c, char c1)
		{
			int sum = (c - 64) + (c1 - 64);
			while (sum > 26)
			{
				sum -= 26;
			}
			return (char)(sum + 64);
		}

		private static (char firstChar, char secondChar, int indexToFind) GetUserInput()
		{
			Console.Write("First Letter: ");
			char firstChar = Convert.ToChar(Console.ReadLine().ToUpper());
			Console.Write("Second Letter: ");
			char secondChar = Convert.ToChar(Console.ReadLine().ToUpper());
			Console.Write("Index of char to find(1 based): ");
			int indexToFind = Convert.ToInt32(Console.ReadLine());
			return (firstChar, secondChar, indexToFind);
		}
		
	}
}