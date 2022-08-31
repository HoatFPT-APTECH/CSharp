using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_HinhHoc
{
    internal class HinhChuNhat : iHinhHoc
    {
        private double dai, rong;

        public HinhChuNhat()
        {
            this.dai = this.rong = 0;
        }

        public HinhChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }

        public double Dai { get => dai; set => dai = value; }
        public double Rong { get => rong; set => rong = value; }

        public void Nhap()
        {
            Console.Write("Nhập chiều dài: ");
            this.dai = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            this.rong = double.Parse(Console.ReadLine());
        } 
        public void HienThi()
        {
            Console.WriteLine("Hình chữ nhật có: Dài: {0}, Rộng: {1}, Diện tích: {2}, Chu Vi: {3}.", this.Dai, this.Rong, this.DienTich(), this.ChuVi());
        }

        public double DienTich()
        {
            return this.Dai * this.Rong;
        }
        public double ChuVi()
        {
            return (this.Dai + this.Rong) * 2;
        }

    }
}
