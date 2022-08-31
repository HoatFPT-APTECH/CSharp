using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    internal class HinhTron : Hinh
    {
        public double Banking { get; set; } 

        public HinhTron()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            this.Banking = 0.0;
        }

        public HinhTron(double banking)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Banking = banking;
        }

        public double ChuVi()
        {
            return Banking * 2 * Math.PI;
        }

        public double DienTich()
        {
            return Math.PI * Math.Pow(Banking, 2);
        }

        public void HienThi()
        {
            Console.WriteLine("Diện tích hình tròn: "+DienTich());
            Console.WriteLine("Chu vi hình tròn : "+ChuVi());
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập bán kình hình tròn: ");
            this.Banking = double.Parse(Console.ReadLine());
        }
    }
}
