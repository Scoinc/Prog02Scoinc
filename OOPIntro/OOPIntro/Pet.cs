using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntro
{
    class Pet
    {
        public string _color;

        public string _species;

        public string _name;
        
        public void Poop()
        {
            Console.WriteLine(_name + " is poop!");
        }
    }
}
