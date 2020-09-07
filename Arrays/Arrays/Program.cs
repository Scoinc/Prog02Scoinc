using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integer array with a length of 5 numbers
            string [] names = new string[5];

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Skriv ett namn: " + i + "/5");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\n\n\n");

            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
