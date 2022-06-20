using System;
using System.Collections.Generic;

namespace Generics
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'L', 'E', 'E', 'N', 'U' };


            program.toPrint<int>(intArray);
            program.toPrint<double>(doubleArray);
            program.toPrint<char>(charArray);
        }

        public static void toPrint<T>(T[] inputArry)
        {
            foreach (var element in inputArry)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------");
        }
    }

}
