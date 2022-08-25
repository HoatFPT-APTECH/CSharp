using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buổi_3
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Program program = new Program();

            int chon;
            do
            {
                chon = program.menu();
                switch (chon)
                {
                    case 1: program.NhapDS_SinhVien();break;
                    case 2: program.HienthiDSSV() ;break;
                    case 3: program.SapXepDSSV() ;break;
                    case 4:
                        Console.WriteLine("Nhập tên sinh viên cần tìm kiểm : ");
                        String name;
                        name = Console.ReadLine();
                        int n = program.TimKiem(name);
                        if (n == -1) Console.WriteLine("Không tìm thấy sinh viên .");
                        else
                        {
                            Console.WriteLine("Tìm thấy sinh viên: ");
                            Student student = (Student)Program.list[n];
                            student.HienThi();
                        }
                        chon = 6;
                        break;
                    case 5: Console.WriteLine("Chương trình kết thúc. Hẹn gặp lại");break;
                    default:
                        Console.WriteLine("Bạn phải chọn từ 1-5. Mời chọn lại");
                        break;
                }

            } while (chon!=5);
          
        }
    }
}
