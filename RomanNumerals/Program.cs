using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumerals
{
	class Program
	{
		private static readonly Dictionary<int, string> IntToRomanLookUpDict = new Dictionary<int, string>()
		{
			{1, "I"},
			{4, "IV"},
			{5, "V"},
			{9, "IX"},
			{10, "X"},
			{40, "XL"},
			{50, "L"},
			{90, "XC"},
			{100, "C"},
			{400, "CD"},
			{500, "D"},
			{900, "CM"},
			{1000, "M"}
		};

		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("Number to convert: ");
				int toConvert = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(ConvertToRomanNumerals(toConvert));
			}
		}

		static string ConvertToRomanNumerals(int number)
		{
			if (number > 3999 || number < 1)
			{
				throw new ArgumentException("Number must be between 1 and 3999 inclusive");
			}

			string romanNumeral = String.Empty;
			foreach (KeyValuePair<int,string> kvp in IntToRomanLookUpDict.Reverse())
			{
				while (number >= kvp.Key)
				{
					romanNumeral = $"{romanNumeral}{kvp.Value}";
					number -= kvp.Key;
				}
			}

			return romanNumeral;
		}
	}
}