using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExercises
{
    internal class Program
    {
        /* static void Main(string[] args)
         {
             var count = 0;
             for (int i = 1; i <= 100; i++)
             {
                 if (i % 3 == 0)
                 {
                     count++;
                 }
             }
             Console.WriteLine("There are {0} numbers between 1 and 100 that are divisible by 3", count);
         }*/

        /*static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number (or type 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input == "ok")
                {
                    break;
                }
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("The sum of all your inputs equals {0}", sum);
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var sum = input;

            for (int i = input - 1; i > 0; i--)
            {
                sum *= i;
            }
            Console.WriteLine("{0}! = {1}", input, sum);
        }
    }
}
