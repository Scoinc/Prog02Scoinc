using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Enter your name:");
                var name = Console.ReadLine();

                Console.WriteLine("Enter your age:");
                var age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Are you alive? true/false");
                var isAlive = Convert.ToBoolean(Console.ReadLine());


                Console.WriteLine("\nname: " + name);
                Console.WriteLine("age: " + age);
                switch (age){
                    case 0:
                        Console.WriteLine("You were just born");
                        break;

                    case 6:
                        Console.WriteLine("You just started school");
                        break;

                    case 10:
                        Console.WriteLine("You've entered the double digits!");
                        break;

                    case 13:
                        Console.WriteLine("You're a teenager!");
                        break;

                    case 18:
                        Console.WriteLine("You're old enough to drink and drive but don't do it at the same time");
                        break;

                    case 20:
                        Console.WriteLine("You're no longer a teenager, it's all downhill from here");
                        break;

                    case 35:
                        Console.WriteLine("Time for a midlife crisis?");
                        break;

                    case 41:
                        Console.WriteLine("Woah, we're halfway there. Woah, livin' on a prayer");
                        break;

                    case 82:
                        Console.WriteLine("You've reached the average lifespan in Sweden, congratulations on being ordinary");
                        break;

                    case 83:
                        Console.WriteLine("You're older than the average swede ever makes it, you did it!");
                        break;

                    case 100:
                        Console.WriteLine("You're pretty darn old!");
                        break;
                }
                Console.WriteLine("State of living: " + isAlive);

                Console.WriteLine("\nDo you want to write again? yes/no");
                var again = Console.ReadLine();

                if (again == "yes")
                {
                    for (var i = 0; i < 3; i++)
                    {
                        Console.WriteLine();
                    }
                }

                else
                {
                    repeat = false;
                }
            }
        }
    }
}
