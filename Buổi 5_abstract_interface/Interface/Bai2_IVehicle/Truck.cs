using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_IVehicle
{
    internal class Truck : Vehicles
    {
        private double truckload;

        public Truck() :base()
        {
            this.truckload = 0;
        }

        public Truck(string maker, string model, double price, double truckload)
            :base(maker, model, price)
        {
            this.truckload = truckload;
        }

        public double Truckload { get => truckload; set => truckload = value; }

        public override void Input()
        {
            base.Input();
            Console.Write("Input truckload: ");
            this.truckload = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Truckload: {0} tons", this.truckload);
        }

    }
}
