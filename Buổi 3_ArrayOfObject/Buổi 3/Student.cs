using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buổi_3
{
    internal class Student
    {
        int  diem;
        String name, msv;

        public Student()
        {
        }

        public int Diem { get => diem; set => diem = value; }
        public string Name { get => name; set => name = value; }
        public string Msv { get => msv; set => msv = value; }

        public void Nhap()
        {
           
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập mã sinh viên: ");
            this.msv = Console.ReadLine();
            
            Console.WriteLine("Nhập tên sinh viên : ");
            this.name = Console.ReadLine();
          
            try
            {
                Console.WriteLine("Nhập điểm của sinh viên : ");
                this.diem = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException ex)
            {

                this.Diem = 0;
             
            }
           
        }
        public void HienThi()
        {
            Console.WriteLine(this.msv+"     "+this.Name+"     "+this.diem);
        }

    }
}
