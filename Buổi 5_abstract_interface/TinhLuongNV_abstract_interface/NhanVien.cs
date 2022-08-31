using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhLuongNV_abstract_interface
{
    internal abstract class NhanVien
    {
        public String hoTen;
        public double luongCB;
        
        public string HoTen { get => hoTen; set => hoTen = value; }
        public double LuongCB { get => luongCB; set => luongCB = value; }

        public NhanVien()
        {
        }

        public NhanVien(string hoTen, double luongCB)
        {
            HoTen = hoTen;
            LuongCB = luongCB;
        }
        public virtual void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập tên nhân viên: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhập lương cơ bản của Nhân viên: ");
            LuongCB = double.Parse(Console.ReadLine());

        } 
        public virtual void HienThi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Tên nhân viên: "+this.HoTen);
            Console.WriteLine("Lương cơ bản: "+this.LuongCB);
        }
        public abstract double TinhLuong();

    }
}
