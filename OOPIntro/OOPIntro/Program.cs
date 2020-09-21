using System;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet leffe = new Pet();
            leffe._name = "Andreas";
            leffe._species = "Dog";
            leffe._color = "pink";

            Person niklas = new Person("Niklas", 33, leffe);

            niklas.Name = "gabbe";

            niklas.Eat();
            niklas.Sleep();
            niklas.petActivate();
        }
    }
}
