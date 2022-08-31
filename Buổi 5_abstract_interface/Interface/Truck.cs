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
           
            try
            {
                Console.Write("Input truckload: ");
                this.truckload = double.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Lỗi Nhập liệu từ bàn phím: "+ex);
                Console.WriteLine("Tự động gắn giá trị : TruckLoad = "+0.0);
            }
            Console.WriteLine("------------------------------------");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Truckload: {0} tons", this.truckload);
        }

    }
}
