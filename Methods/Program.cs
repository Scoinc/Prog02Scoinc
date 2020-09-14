using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum: " + intSum() + "\n");
            wordReverse();
            highLow();
        }

        private static void highLow()
        {
            Console.WriteLine("\nInput 3 numbers:");
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Skriv ett nummer: " + i + "/3");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);
            Console.WriteLine("Biggest number: " + numbers[numbers.Length - 1] + "\nsmallest number: " + numbers[0]);
        }

        private static void wordReverse()
        {
            string[] words = new string[3];
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine("Skriv ett namn: " + i + "/3");
                words[i] = Console.ReadLine();
            }

            Console.WriteLine("");

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
        }

        private static int intSum()
        {
            Console.WriteLine("Input 3 numbers");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            int numberThree = Convert.ToInt32(Console.ReadLine());

            int sum = numberOne + numberTwo + numberThree;
            return sum;
        }
    }
}
