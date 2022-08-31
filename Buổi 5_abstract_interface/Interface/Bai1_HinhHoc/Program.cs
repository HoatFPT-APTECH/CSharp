using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_HinhHoc
{
    internal class Program
    {
        static void Work(iHinhHoc hinhhoc)
        {
            hinhhoc.Nhap();
            hinhhoc.DienTich();
            hinhhoc.ChuVi();
            hinhhoc.HienThi();
        }

        static void Menu(out int chon)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Hình chữ nhật.");
            Console.WriteLine("2. Hình Vuông.");
            Console.WriteLine("3. Hình Tròn.");
            Console.WriteLine("4. Thoát..");
            Console.WriteLine("Vui lòng chọn số từ 1 đến 4 theo Menu.");
            chon = int.Parse(Console.ReadLine());   
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int chon;
            do
            {
                Menu(out chon);
                switch (chon)
                {
                    case 1:
                        HinhChuNhat hcn = new HinhChuNhat();
                        Work(hcn);
                        break;
                    case 2:
                        HinhVuong hv = new HinhVuong();
                        Work(hv);
                        break;
                    case 3:
                        HinhTron ht = new HinhTron();
                        Work(ht);
                        break;
                    case 4:
                        Console.WriteLine("Tạm biệt.");
                        break;
                    default:
                        Console.WriteLine("Vui lòng chọn số từ 1 đến 4");
                        break;
                }
            } while (chon != 4);
        }
    }
}
