using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buổi_8_Collection
{
    internal class Ex1_Cylinder
    {
        double height, radius;
        double BaseArea, LateralArea, TotalArea, Volume;

        public Ex1_Cylinder(double height, double radius)
        {
            this.height = height;
            this.radius = radius;
        }

        public Ex1_Cylinder()
        {
        }
        public void Input()
        {
            Console.Write("Enter the dimenstion of the cylinder \n Radius: ");
            this.radius = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            this.height = double.Parse(Console.ReadLine());
        }
        public void Process()
        {
            
            BaseArea = radius * radius * Math.PI;
            LateralArea = 2 * Math.PI * radius * height;
            TotalArea = 2*Math.PI*radius*(height+radius);
            Volume=Math.PI*radius*radius*height;

        }
        public void Result()
        {
            Console.WriteLine("Cylinder Characteristics: ");
            Console.WriteLine("Radius: "+this.radius+", Height: "+this.height);
            Console.WriteLine("Base: "+this.BaseArea+"| Lateral: "+this.LateralArea+"| Total: "+this.TotalArea+" | Volume: "+this.Volume);
        }
        static void Main(string[] args)
        {
            Ex1_Cylinder ex1 = new Ex1_Cylinder();
            ex1.Input();
            ex1.Process();
            ex1.Result();
        }

    }
}
