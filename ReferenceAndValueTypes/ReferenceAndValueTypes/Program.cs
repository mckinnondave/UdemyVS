﻿using System;

namespace ReferenceAndValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(String.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0])); // both array1 and 2 have a first value of 0 because we changed it on line 20.
        }
    }
}
