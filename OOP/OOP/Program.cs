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
            string product = "";

            Customer customer = new Customer();

            Console.WriteLine("Please write your name:");
            customer._name = Console.ReadLine();

            Console.WriteLine("What do you want to purchase?\n1. Chocolate\n2. Ice cream\n3. Liquorice");
            int SC = Convert.ToInt32(Console.ReadLine());
            switch (SC)
            {
                case 1:
                    product = "Chocolate";
                    break;
                case 2:
                    product = "Ice cream";
                    break;
                case 3:
                    product = "Liquorice";
                    break;
                default:
                    break;
            }



            //Gets product and price
            Console.WriteLine("How many " + product + "s are you going to buy?");
            ammount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHow much do those cost?");
            int price = Convert.ToInt32(Console.ReadLine());

            //Creates given product product with given price and adds it to cart
            if (product == "Chocolate")
            {
                Chocolate chocolate = new Chocolate(ammount, price);
                customer._cart.Add(chocolate);

                foreach (var Product in customer._cart)
                {
                    Console.WriteLine(customer._name + " has ordered " + chocolate._ammount + " chocolates for " + chocolate.total + " currency");
                }
            }

            else if (product == "Ice cream")
            {
                IceCream iceCream = new IceCream(ammount, price);
                customer._cart.Add(iceCream);
                foreach (var Product in customer._cart)
                {
                    Console.WriteLine(customer._name + " has ordered " + iceCream._ammount + " ice creams for " + iceCream.total + " currency");
                }
            }

            else if (product == "Liquorice")
            {
                Liquorice liquorice = new Liquorice(ammount, price);
                customer._cart.Add(liquorice);
                foreach (var Product in customer._cart)
                {
                    Console.WriteLine(customer._name + " has ordered " + liquorice._ammount + " pieces of liquorice for " + liquorice.total + " currency");
                }
            }


        }
    }
}
