using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhLuongNV_abstract_interface
{
    internal class NVKinhdoanh:NhanVien
    {
       public  double doanhThu;

        public NVKinhdoanh():base()
        {
        }

        public NVKinhdoanh(string hoten,double luongcb,double doanhThu) : base(hoten,luongcb)
        {
            this.doanhThu = doanhThu;
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Lương của NV Kinh doanh trong tháng:" + this.TinhLuong());

        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập doanh thu trong tháng của nhân viên kinh doanh: ");
            this.doanhThu=double.Parse(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            return (luongCB + doanhThu * 0.1);
        }

    }
}
