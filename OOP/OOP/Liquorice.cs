using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Liquorice : Product
    {
        public Liquorice(int ammount, int price)
        {
            _ammount = ammount;
            _price = price;
            total = _ammount * _price;
        }
    }
}
