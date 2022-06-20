using System;

namespace Generics
{
    class UC1
    {
        public static void Main(string[] args)
        {
            int[] intArry = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArry = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArry = { 'P', 'R', 'A', 'S', 'A', 'N', 'N', 'A' };

            program.toPrint(intArry);
            program.toPrint(doubleArry);
            program.toPrint(charArry);

        }

        public static void toPrint(int[] inputArry)
        {
            foreach (int element in inputArry)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------");
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
