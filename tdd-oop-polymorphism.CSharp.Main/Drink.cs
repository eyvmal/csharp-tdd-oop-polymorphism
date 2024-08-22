using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Drink(string name, int price) : IProduct
    {
        public int GetPrice()
        {
            return price;
        }

        public string GetName()
        {
            return name;
        }
    }
}
