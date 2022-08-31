using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1

{
    public class HinhChuNhat : Hinh
    {
        double Dai , Rong;

        public HinhChuNhat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            this.Dai = 0.0;

            this.Rong=0.0;  
        }

        public HinhChuNhat(double dai, double rong)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Dai = dai;
            Rong = rong;
        }

        public double Dai1 { get => Dai; set => Dai = value; }
        public double Rong1 { get => Rong; set => Rong = value; }

       public virtual void Nhap()
        {
           
            Console.WriteLine("Nhập Chiều dài hình chữ nhật: ");
            this.Dai = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng hình chữ nhật : ");
            this.Rong=double.Parse(Console.ReadLine());
        }
            
       public virtual void HienThi()
        {
            Console.WriteLine("Chu vi Hình chữ nhật : "+ChuVi());
            Console.WriteLine("Diện tích hình chữ nhật: "+DienTich());
        }
       public virtual double DienTich()
        {
            return Dai * Rong;
        }
      public virtual double ChuVi()
        {
            return (Dai + Rong) * 2;
        }

    
    }
}
