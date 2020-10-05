using System;
using System.Collections;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {


            bool shopping = true;
            while (shopping)
            {
                //Gets product and price
                Console.WriteLine("What would you like to purchase?");
                string product = Console.ReadLine();

                Console.WriteLine("\nHow much does that cost?");
                int price = Convert.ToInt32(Console.ReadLine());

                //Creates product with given product and price
                new Product(product, price);


                //I might think of a not horrible way to do this at some point
                Console.WriteLine("Would you like to continue shopping? Y/N");
                var stay = Console.ReadLine();

                if(stay == "Y")
                {

                    Console.WriteLine();
                }

                else
                {
                    //Gets name, age and country of residence
                    Console.WriteLine("To continue purchase please write your name, age and country of residence:");
                    Console.WriteLine("\nName:");
                    String name = Console.ReadLine();

                    Console.WriteLine("\nage:");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\ncountry of residence");
                    String country = Console.ReadLine();

                    //Creates a customer with the given name, age and country
                    new Customer(name, age, country);

                    //Stops the loop
                    shopping = false;
                }
            }
        }
    }
}
