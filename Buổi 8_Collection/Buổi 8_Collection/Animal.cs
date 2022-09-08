using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buổi_8_Collection
{
    public abstract class Animal
    {
        double weight;
        String name;
        public void SetMe(double w,string n)
        {
            this.weight = w;
            this.name = n;
        }
        public void Show()
        {
            Console.WriteLine("Name: "+this.name+", Weight: "+this.weight);
        }
    }
}
