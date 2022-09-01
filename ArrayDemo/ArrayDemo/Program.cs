using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LENGTH
            var numbers = new [] { 3, 7, 8, 2, 14, 6 };
            Console.WriteLine("Length: " + numbers.Length);
            Console.WriteLine();

            // IndexOf
            var index = Array.IndexOf(numbers, 8);
            Console.WriteLine(index);
            Console.WriteLine();

            //CLEAR
            Array.Clear(numbers, 0, 2);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // COPY
            var newArr = new int[3];
            Array.Copy(numbers, newArr, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var num in newArr)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // SORT
            Array.Sort(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // REVERSE
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse(): ");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
