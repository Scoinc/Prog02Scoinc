using Abstraktion.Concretes;
using Abstraktion.Interfaces;
using System;
using System.Collections.Generic;

namespace Abstraktion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            var doggo = new Dog();
            doggo.Fur = "fur";
            doggo.Limbs = 4;

            var chinZilla = new Chinchilla();
            chinZilla.Fur = "fur";
            chinZilla.Limbs = 4;

            animals.Add(doggo);
            animals.Add(chinZilla);

            var chinchillas = new List<IChinchilla>();
            var dogs = new List<IDog>();

            foreach (var animal in animals)
            {
                Console.WriteLine("This animal has " + animal.Fur);
                Console.WriteLine("This animal has " + animal.Limbs + " limbs");

                if(animal is Dog dog)
                {
                    dogs.Add(dog);
                }

                else if(animal is Chinchilla chinchilla)
                {
                    chinchillas.Add(chinchilla);
                }
            }

            foreach (var dogg in dogs)
            {
                dogg.Move();
                dogg.Sleep();
                dogg.SmellPoo();
            }

            foreach (var chinchilla in chinchillas)
            {
                chinchilla.Move();
                chinchilla.Sleep();
                chinchilla.Dustbathe();
            }
        }
    }
}
