using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tham_chiếu_ref
{
    internal class assignment_1
    {
        public void nhap(out double a,out double b,out double c)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập a , b , c cho phương trình bậc nhất : \n a*x^2+b*x+c=0 ");
            Console.Write("a = ");a = double.Parse(Console.ReadLine());
            Console.Write("b = ");b=double.Parse(Console.ReadLine());
            Console.Write("c = "); c = double.Parse(Console.ReadLine());
        }
        public Boolean kt(double a, double b, double c)
        {
            double delta;
            delta = b * b - 4 * a * c;
            if (delta < 0)
                return false;
            else return true;
        }
      
        
        
        void giaiPTB2(out double x1,out double x2,double a, double b,double c)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            assignment_1 p = new assignment_1();
            double delta;
            delta = b * b - 4 * a * c;
            x1 = (-b - Math.Sqrt(delta)) / (2 * a);

            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            if (p.kt(a, b, c) == false)
            {
                Console.WriteLine("Phương trình vô nghiệm !");
            }
            else if(p.kt(a, b, c) == true && delta>0)
            {
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt : ");
              
                Console.WriteLine("x1= "+x1);
                Console.WriteLine(" x2= "+x2);

            }
            else
            {
           
                Console.WriteLine("Phương trình có nghiệm duy nhất: x ="+x1);
            }
        }
        static void Main(string[] args)
        {
            double a, b, c;
            assignment_1 p= new assignment_1();
            p.nhap(out a, out b, out c);
            double x1, x2;
            p.giaiPTB2(out x1,out x2,a,b,c);

            
        }
    }
}
