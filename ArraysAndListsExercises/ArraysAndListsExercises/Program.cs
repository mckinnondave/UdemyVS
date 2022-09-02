using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListsExercises
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Please enter a name (or hit ENTER to quit): ");
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    break;
                }
                names.Add(input);
            }

            if (names.Count > 2)
            {
                Console.WriteLine("{0}, {1}, and {2} others like your post", names[0], names[1], names.Count - 2);
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            }   
            else if (names.Count == 1)
            {
                Console.WriteLine("{0} likes your post", names[0]);
            }
            else
            {
                Console.WriteLine();
            }
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            var reversed = new String(array);
            Console.WriteLine("The reversed version of this name is: {0}", reversed);
        }
    }
}
