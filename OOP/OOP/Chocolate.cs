using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Chocolate : Product
    {
        public Chocolate(int ammount, int price)
        {
            _ammount = ammount;
            _price = price;
            total = _ammount * _price;
        }
    }
}

