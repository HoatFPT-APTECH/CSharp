using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_HinhHoc
{
    internal class HinhTron : iHinhHoc
    {
        private double bankinh;

        public HinhTron()
        {
            this.bankinh = 0;
        }

        public HinhTron(double bankinh)
        {
            this.bankinh = bankinh;
        }

        public double Bankinh { get => bankinh; set => bankinh = value; }

        public double ChuVi()
        {
            return 2 * Math.PI * this.bankinh;
        }

        public double DienTich()
        {
            return Math.PI * this.bankinh * this.bankinh;
        }

        public void HienThi()
        {
            Console.WriteLine("Hình tròn có: Bán kính: {0}, Diện tích: {1}, Chu Vi: {2}.", this.bankinh, this.DienTich(), this.ChuVi());
        }

        public void Nhap()
        {
            Console.Write("Nhập bán kính: ");
            this.bankinh = double.Parse(Console.ReadLine());
        }
    }
}
