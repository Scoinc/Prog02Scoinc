using System;
using System.Collections;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shopping = true;
            int total = 0;
            int ammount = 0;

            Customer customer = new Customer();

            while (shopping)
            {
                //Gets product and price
                Console.WriteLine("How many are you going to buy?");
                ammount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nHow much does that cost?");
                int price = Convert.ToInt32(Console.ReadLine());

                //Creates product with given product and price and adds it to cart
                Product product2 = new Product(ammount, price);
                customer._cart.Add(product2);

                //I might think of a not horrible way to do this at some point
                Console.WriteLine("Would you like to continue shopping? Y/N");
                var stay = Console.ReadLine();

                if(stay.ToLower() == "y")
                {
                    Console.WriteLine();
                }
                
                else
                {
                    //Gives customer a name, age and country of residence
                    Console.WriteLine("To continue purchase please write your name, age and country of residence:");
                    Console.WriteLine("\nName:");
                    customer._name = Console.ReadLine();

                    Console.WriteLine("\nage:");
                    customer._age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\ncountry of residence");
                    customer._country = Console.ReadLine();

                    //Stops the loop
                    shopping = false;

                    foreach (var Product in customer._cart)
                    {
                        Console.WriteLine(customer._name + " has ordered " + product2._ammount + " of whatever i'm selling for " + product2.total + " currency");
                    }
                    }
            }
        }
    }
}
