using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_IVehicle
{
    internal class Car : Vehicles
    {
        private string color;

        public Car() : base()
        {
            color = "";
        }

        public Car(string maker, string model, double price, string color)
            : base(maker, model, price)
        {
            this.color = color;
        }
        public string Color { get => color; set => color = value; }

        public override void Input()
        {
            base.Input();
            Console.Write("Input color: ");
            this.color = Console.ReadLine();
            Console.WriteLine("------------------------------------");
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Color: " + this.Color);
        }
    }
}
