using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IProduct> _products = new List<IProduct>();

        public void add(IProduct p)
        {
            _products.Add(p);
        }

        public int getTotal()
        {
            return _products.Sum(x => x.GetPrice());
        }

        public bool isInBasket(string name)
        {
            return _products.Any(p => p.GetName().Equals(name));
        }
    }
}
