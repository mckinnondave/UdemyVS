using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercises
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter a nubmer between 1-10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number > -1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }*/

        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            var num2 = Convert.ToInt32(Console.ReadLine());

            var max = (num1 > num2) ? num1 : num2;
            Console.WriteLine("Max is {0}", max);
        }*/

        /*static void Main(string[] args)
        {
            Console.WriteLine("Please enter a width of an image");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a height of an image");
            var height = Convert.ToInt32(Console.ReadLine());

            var format = (width < height) ? "portrait" : "landscape";

            Console.WriteLine("Your image is {0}", format);
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit");
            var limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How fast is the car?");
            var carSpeed = Convert.ToInt32(Console.ReadLine()); 

            if (carSpeed < limit)
            {
                Console.WriteLine("OK!");
            }
            if (carSpeed > limit)
            {
                var demerits = (carSpeed - limit)/5;
                if (demerits < 12)
                {
                    Console.WriteLine("Demerits: {0}", demerits);
                }
                else
                {
                    Console.WriteLine("Demerits: {0} - License Suspended", demerits);
                }
            }
        }
    }
}
