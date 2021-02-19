using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace DistinctPrimeFactorisation
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            List<int> factors = FindPrimeFactors(number);
            factors = RemoveDuplicates(factors);
            Console.WriteLine(Product(factors));
        }

        /// <summary>
        /// Sums a collection of numbers, O(n) time
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int Sum(IEnumerable<int> numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }

        /// <summary>
        /// Gets the product of a collection of numbers, O(n)
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int Product(IEnumerable<int> numbers)
        {
            int total = 1;
            foreach (int number in numbers)
            {
                total *= number;
            }
            return total;
        }

        /// <summary>
        /// Removes any duplicates from a list, O(n^2) time due to .RemoveAt and .Add being O(n)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static List<T> RemoveDuplicates<T>(List<T> collection)
        {
            List<T> seen = new List<T>();
            for (int i = 0; i < collection.Count; i++)
            {
                if (seen.Contains(collection[i]))
                {
                    collection.RemoveAt(i);
                    i--;
                }
                else
                {
                    seen.Add(collection[i]);
                }
            }
            return collection;
        }

        public static List<int> FindPrimeFactors(int number)
        {
            List<int> primeFactors = new List<int>();

            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    primeFactors.Add(i);
                    number /= i;
                }
            }

            return primeFactors;
        }

        /// <summary>
        /// Factorises a number to its factors, if the number is prime it is returned
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> FindFactors(int number)
        {
            List<int> factors = new List<int>();
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                }
            }
            if (factors.Count == 0)
            {
                factors.Add(number);
            }
            return factors;
        }

        public static bool IsPrime(this int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
