using System;

namespace stringsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Dave";
            var lastName = "McKinnon";

            var fullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(fullName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi John,
Look into the following paths:
c:\folder1\folder2
c:\folder3";
            Console.WriteLine(text);
        }
    }
}
