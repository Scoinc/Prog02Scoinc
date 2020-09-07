using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integer array with a length of 5 numbers
            int loops = 8;
            int[] numbers = new int[loops];

            for(int i = 0; i < loops; i++)
            {
                numbers[i] = i;
                Console.WriteLine(i);
            }

            int sum = 0;

            for (int i = 0; i < loops; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("\nsum of numbers: " + sum);
        }
    }
}
