using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_HinhHoc
{
    internal class HinhVuong : iHinhHoc
    {
        private double canh;

        public HinhVuong()
        {
            canh = 0;
        }

        public HinhVuong(double canh)
        {
            this.canh = canh;
        }

        public double Canh { get => canh; set => canh = value; }

        public void Nhap()
        {
            Console.Write("Nhập cạnh: ");
            this.canh = double.Parse(Console.ReadLine());
        }

        public void HienThi()
        {
            Console.WriteLine("Hình vuông có: Cạnh: {0}, Diện tích: {1}, Chu Vi: {2}.", this.Canh, this.DienTich(), this.ChuVi());
        }

        public double DienTich()
        {
            return this.canh * this.canh;
        }

        public double ChuVi()
        {
            return this.canh * 4;
        }
    }
}
