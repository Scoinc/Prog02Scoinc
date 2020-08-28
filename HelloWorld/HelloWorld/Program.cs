using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Are you alive? true/false");
            var alive = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("State of living: " + alive);
        }
    }
}
