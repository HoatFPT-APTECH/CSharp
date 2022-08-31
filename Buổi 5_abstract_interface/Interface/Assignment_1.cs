using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1

{
    internal class Assignment_1
    {
        public Assignment_1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
        }

        public int menu()
        {
            int chon;
            Console.WriteLine("Menu\r\n1. Hình chữ nhật\r\n2. Hình vuông\r\n3. Hình tròn\r\n4. Thoát");
            chon=int.Parse (Console.ReadLine());
            return chon;
        }
        public void work(Hinh element)
        {
            element.Nhap();
            element.HienThi();
        }
        static void Main(string[] args)
        {
            Assignment_1     b1= new Assignment_1(); ;
            Hinh hinh;
            int chon;
            do
            {
                chon = b1.menu();
                switch (chon)
                {
                    case 1:
                        {
                            hinh = new HinhChuNhat();
                            b1.work(hinh);
                            break;
                        }
                    case 2:
                        {
                            hinh = new HinhVuong();
                            b1.work(hinh);
                            break;
                        }
                    case 3:
                        {
                            hinh = new HinhTron();
                            b1.work(hinh);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Xin chào và hẹn gặp lại.");break;
                        }
                    default:
                        Console.WriteLine("Vui lòng chọn từ 1->4. Mời chọn lại!");
                        break;
                }
            } while (chon!=4);
        }
    }
}
