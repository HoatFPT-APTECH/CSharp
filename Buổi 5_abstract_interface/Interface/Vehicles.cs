using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_IVehicle
{
    internal class Vehicles : IVehicle
    {
        private string maker, model;
        private double price;

        public Vehicles()
        {
            maker = "";
            model = "";
            price = 0;
        }

        public Vehicles(string maker, string model, double price)
        {
            this.maker = maker;
            this.model = model;
            this.price = price;
        }

        public string Maker { get => maker; set => maker = value; }
        public string Model { get => model; set => model = value; }
        public double Price { get => price; set => price = value; }

        public virtual void Display()
        {
            Console.WriteLine("Vehicles:");
            Console.WriteLine("Maker: " + this.Maker);
            Console.WriteLine("Model: " + this.Model);
            Console.WriteLine("Price: " + this.Price);
        }

        public virtual void Input()
        {
            Console.Write("Input maker: ");
            this.maker = Console.ReadLine();
            Console.Write("Input model: ");
            this.model = Console.ReadLine();
            Console.Write("Input price: ");
            this.price = double.Parse(Console.ReadLine());
        }
    }
}
