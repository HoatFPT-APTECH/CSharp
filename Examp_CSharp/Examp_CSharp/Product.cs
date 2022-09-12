using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examp_CSharp
{
    public abstract class Product
    {
        String id, name;
        double price;

        protected Product()
        {
        }

        protected Product(string id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public abstract double computeTax();
    }
}
