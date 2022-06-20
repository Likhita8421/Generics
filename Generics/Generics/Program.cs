using System;

namespace Generics
{
    class program
    {
        public static void Main(string[] args)
        {
            //int[] intArry = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'L', 'E', 'E', 'N', 'U' };

            //program.toprint(intArray);
            program.toprint(doubleArray);
            program.toprint(charArray);

        }

        public static void toprint(double[] inputArry)
        {
            foreach (double element in inputArry)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------");
        }
        public static void toprint(char[] inputArry)
        {
            foreach (char element in inputArry)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------");
        }
    }

}
