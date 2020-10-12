using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Product
    {
        public int _ammount;
        public int _price;
        public int total;

        public Product(int ammount, int price)
        {
            _ammount = ammount;
            _price = price;
            total = _ammount * _price;
        }
    }
}
