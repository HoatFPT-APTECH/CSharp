using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buổi_9
{
    internal class Products
    {
        String ID;
        string Name;
        double Price;

        public Products()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

        }

        public Products(String iD, string name, double price)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            ID = iD;
            Name = name;
            Price = price;
        }

     
        public string Name1 { get => Name; set => Name = value; }
        public double Price1 { get => Price; set => Price = value; }
        public string ID1 { get => ID; set => ID = value; }

        public void Input()
        {
            Console.WriteLine("Enter the ID for product: ");
            this.ID = Console.ReadLine();
            Console.WriteLine("Enter the Name for product: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter the Price for Product: ");
            this.Price = double.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine(this.ID+"       "+this.Name+"        "+this.Price);
        }
    }
}
