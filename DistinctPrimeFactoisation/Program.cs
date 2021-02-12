using System;
using System.Collections.Generic;

namespace DistinctPrimeFactoisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            List<int> factors = FindFactors(number);
            RemoveDuplicates(ref factors);
            int sum = Sum(factors);
        }

        private static int Sum(List<int> numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }

        private static void RemoveDuplicates<T>(ref List<T> collection)
        {
            List<T> seen = new List<T>();
            for (int i = 0; i < collection.Count; i++)
            {
                if (seen.Contains(collection[i]))
                {
                    collection.RemoveAt(i);
                }
                else
                {
                    seen.Add(collection[i]);
                }
            }
        }

        private static List<int> FindFactors(int number)
        {
            throw new NotImplementedException();
        }
    }
}
