using Abstraktion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion.Concretes
{
    class Dog : Animal, IDog
    {
        public void SmellPoo()
        {
            Console.WriteLine("Dog is sniffing");
        }

        public void Move()
        {
            Console.WriteLine("Dog is zooming around");
        }

        public void Sleep()
        {
            Console.WriteLine("Dog is taking a nap");
        }
    }
}
