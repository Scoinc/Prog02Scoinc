using Abstraktion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion.Concretes
{
    class Chinchilla : Animal, IChinchilla
    {
        public void Dustbathe()
        {
            Console.WriteLine("Chinchilla is cleaning it self");
        }

        public void Move()
        {
            Console.WriteLine("Chinchilla leaps majestically");
        }

        public void Sleep()
        {
            Console.WriteLine("Chinchilla is resting peacefully");
        }
    }
}
