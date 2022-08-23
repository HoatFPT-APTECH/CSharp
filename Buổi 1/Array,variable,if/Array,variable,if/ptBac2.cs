using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_variable_if
{
    internal class ptBacNhat
    {
        
       public Boolean kt(double a, double b, double c)
        {
            double delta;
            delta = b * b - 4 * a * c;
            if (delta < 0)
                return false;
            else   return true;
        }
        public double nghiemx1(double a, double b, double c)
        {
            double delta;
            delta = b * b - 4 * a * c;
            return (float)(-b + Math.Sqrt(delta)) / (2 * a);
        }
        public double nghiemx2(double a, double b, double c)
        {
            double delta;
            delta = b * b - 4 * a * c;
            return (-b -Math.Sqrt(delta)) / (2 * a);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ptBacNhat p = new ptBacNhat();
            Console.InputEncoding = Encoding.UTF8;
            double a, b, c;
            double x1, x2;
            
            do
            {
                Console.WriteLine("Phương trình bậc hai : a*x^2+b*x+c=0");
                Console.Write("Nhập a= ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhập b= ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhập c= ");
                c = Convert.ToDouble(Console.ReadLine());
               String vn= (p.kt(a, b, c) == false) ?"Phương trình vô nghiệm: => Mời nhập lại.":"\n*****************!*************!************" ;
                Console.WriteLine(vn);
            } while (p.kt(a,b,c)==false);
            Console.WriteLine("Kết quả : Phương trình {0}*x^2+{1}*x+{2}=0 có nghiệm",a,b,c);
            if(p.nghiemx1(a,b,c)==p.nghiemx2(a,b,c))
                Console.WriteLine("Phương trình có nghiệm duy nhất : x= "+p.nghiemx1(a,b,c));
            else Console.WriteLine("Phương trình có 2 nghiệm phân biệt:\n x1={0} \n x2={1}",p.nghiemx1(a,b,c),p.nghiemx2(a,b,c));
        }
    }
}
