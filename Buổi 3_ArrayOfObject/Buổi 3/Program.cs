using System.Collections;
using System.Text;

namespace Buổi_3
{
    internal class Program
    {
      public static ArrayList  list;
        public Program()
        {
            list = new ArrayList();
            
        }

        public int menu()
        {
            int chon;
            Console.WriteLine("Menu: \n 1.Nhập danh sách sinh viên\r\n 2.Hiển thị danh sách sinh viên\r\n 3.Sắp xếp theo điểm giảm dần\r\n 4.Tìm sinh viên theo họ tên\r\n 5.Thoát chương trình\r\n Mời chọn chức năng tử 1->5: ");
            chon=int.Parse(Console.ReadLine()); 
            return chon;

        }
       

        public void NhapDS_SinhVien()
        {

            Console.WriteLine(" Nhập thông tin trống để kết thúc thêm sinh viên: ");
            int i = 0;
            do
            {
                
                Console.WriteLine("Sinh viên thứ {0}: ",i+1);
                Student s= new Student();
                s.Nhap();
                if (String.IsNullOrEmpty(s.Msv))
                {
                    Console.WriteLine("Nhập danh sách sinh viên thành công.");break;
                }
                list.Add(s);
                i++;



            } while (true);
        }
        public void HienthiDSSV()
        {
            int n = list.Count;
            Console.WriteLine("Hiển thị danh sách sinh viên: ");
            int i = 1;
            foreach (Student e in list)
            {
                Console.Write(i+". ");
                
                e.HienThi();

                i++;
             
            }
        }
        public void SapXepDSSV()
        {
            for (int i = 0; i < list.Count-1; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {  

                    Student s1= (Student)list[i];
                   

                    Student s2= (Student)list[j];
                   
                    if (s1.Diem < s2.Diem)
                    {
                        Student temp =s1;
                        list[i] = s2;
                        list[j] = temp; 
                    }
                }
            
            }
            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo thứ tự giảm dần  điểm của sinh viên");
            HienthiDSSV();

        }
        public int TimKiem(string name)
        {
           

            for (int i = 0; i < list.Count  ; i++)
            {
                Student s = (Student)list[i];
                if (s.Name.ToLower().Equals(name.ToLower()))
                {
                    return i;
                }
            }
            return -1;
        }

    }
}