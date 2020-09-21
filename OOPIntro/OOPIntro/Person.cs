using System;

namespace OOPIntro
{
    class Person
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        int _age;

        Pet _pet;

        public Person(string name, int age, Pet pet)
        {
            _name = name;
            _age = age;
            _pet = pet;
        }

        public void petActivate()
        {
            _pet.Poop();
        }

        public void Eat()
        {
            Console.WriteLine(_name + " is eating...");
        }

        public void Sleep()
        {
            Console.WriteLine(_name + " is sleeping...");
        }
    }
}
