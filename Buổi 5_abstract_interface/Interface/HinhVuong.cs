using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    internal class HinhVuong : HinhChuNhat
    {
        public HinhVuong() : base() 
        {
            base.Dai1 = base.Rong1;
        }

        public HinhVuong(double canh)
        {
            base.Dai1 = base.Rong1 = canh;
        }

        public double ChuVi()
        {
            return Dai1 * 4;
        }

        public  override double DienTich()
        {
            return Dai1*Dai1;
        }

        public override void HienThi()
        {
            Console.WriteLine("Chu vi hình vuông: "+ChuVi());
            Console.WriteLine("Diện tích hình vuông : "+DienTich());

        }

        public override void Nhap()
        {
            Console.WriteLine("Nhập vào độ dải cạnh hình vuông: ");
            this.Dai1 = double.Parse(Console.ReadLine());
        }
    }
}
