using System.Collections.Generic;
using System;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // INDEX OF
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));

            // LAST INDEX OF
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            // COUNT
            Console.WriteLine("Count: " + numbers.Count);
            Console.WriteLine();

            // REMOVE
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
