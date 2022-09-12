using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examp_CSharp
{
    public class Phone : Product
    {
        public Phone()
        {
        }

        public Phone(string id, string name, double price) : base(id, name, price)
        {
        }

        public override double computeTax()
        {
            return base.Price * 10 / 100;
        }
    }
}
