using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhLuongNV_abstract_interface
{
    internal class NVKiThuat:NhanVien
    {
        int ngayCong;

        public NVKiThuat():base()
        {
        }

        public NVKiThuat(string hoTen, double luongCB,int ngayCong) : base(hoTen, luongCB)
        {
            this.ngayCong=ngayCong;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập số ngày công của nhân viên kỹ thuật :");
            this.ngayCong = int.Parse(Console.ReadLine());
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Lương của NV Kỹ thuật trong tháng:"+this.TinhLuong());
        }
        public override double TinhLuong()
        {

            return( luongCB + (double)ngayCong * 100000);
        
        }
    }
}
