using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buổi_8_Collection
{
    internal class Ass2_Dictionary
    {
        Dictionary<string, string> data;

        public Ass2_Dictionary()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            data = new Dictionary<string, string>();    
        }
        public int Menu()
        {
            int chon;
            Console.WriteLine("Từ điển Anh - Việt\r\n1. Thêm từ mới \r\n2. Hiển thị toàn bộ \r\n3. Tra từ \r\n4. Sửa từ  \r\n5. Xóa từ \r\n6. Thoát\r\nMời bạn chọn (1-6):");
            chon = int.Parse(Console.ReadLine());
            return chon;
        }
        public void ThemTuMoi()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine(" ");
            String eng, vie;
            Console.WriteLine("Thêm từ mới.Nhập từ tiếng Anh và nghĩa tiếng Việt bên dưới! ");
            Console.WriteLine("Nhập từ tiếng anh: ");
            eng=Console.ReadLine();
            Console.WriteLine("Nhập nghĩa tiếng việt: ");
            vie=Console.ReadLine();
            this.data.Add(eng, vie);
            Console.WriteLine(" ");
            Console.WriteLine("*********************************************************");

        }
        public void HienThiToanBo()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine(" ");
            Console.WriteLine("Danh sách từ có trong từ điển: ");
            foreach (KeyValuePair<String,string> item in this.data)
            {
                Console.WriteLine(item.Key+" : "+item.Value);
            }
            Console.WriteLine(" ");
            Console.WriteLine("*********************************************************");
        }
        public String search(String eng)
        {

            if (this.data.ContainsKey(eng)) return this.data[eng];
            return "not found";
        }
        public void changeVocal(String eng)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine(" ");
            string vie;
            if (this.search(eng).Equals("not found"))
            {
                Console.WriteLine("Từ bạn cần sửa không có trong từ điển. ");
            }
            Console.WriteLine("Từ cũ: "+eng+" : " + this.data[eng]);
            Console.WriteLine("Nhập từ mới tiếng việt muốn sửa: ");
            vie = Console.ReadLine();
            this.data[eng] = vie;
            Console.WriteLine("Từ sau khi sửa : "+eng+" : "+this.data[eng]);
            Console.WriteLine(" ");
            Console.WriteLine("*********************************************************");
        }
        public void remove(String eng)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine(" ");
            if (this.search(eng).Equals("not found"))
            {
                Console.WriteLine("Từ bạn cần xoá không có trong từ điển. ");
            }
            string yes;
            do
            {
                Console.WriteLine("Bạn có chắc muốn xoá từ : " + eng + " : " + this.data[eng] + " . Nhấn 'y ' để xoá, 'n' không xoá ? ");
                yes= Console.ReadLine();    
            } while (yes.Equals("y")==false&&yes.Equals("n")==false);

            if (yes.Equals("y"))
            {
                this.data.Remove(eng);
                Console.WriteLine("Xoá từ thành công");
            }
            Console.WriteLine(" ");
            Console.WriteLine("*********************************************************");
        }
        static void Main(string[] args)
        {
            int chose;
            Ass2_Dictionary b2 = new Ass2_Dictionary();
            do
            {
                chose = b2.Menu();
                switch (chose)
                {
                    case 1: b2.ThemTuMoi();break;
                    case 2: b2.HienThiToanBo();break;
                    case 3:
                        {
                            Console.WriteLine("*********************************************************");
                            Console.WriteLine(" ");
                            string eng,vie;
                            Console.WriteLine("Nhập vào từ cần tra (Tiếng Anh): ");
                            eng = Console.ReadLine(); 
                            vie=b2.search(eng);
                            if (vie.Equals("not found"))
                            {
                                Console.WriteLine("Không tìm thấy từ cần tra");
                            }
                            else
                            {
                                Console.WriteLine("Đã tìm thấy từ cần tra.");
                                Console.WriteLine(eng+" : "+vie);
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("*********************************************************");
                            break;
                        }
                    case 4: {
                            string eng;
                            Console.WriteLine("Nhập từ cần sửa (Tiếng Anh): ");
                            eng=Console.ReadLine();
                            b2.changeVocal(eng);
                            break;
                       

                        }
                    case 5: {
                            string eng;
                            Console.WriteLine("Nhập từ cần xoá (Tiếng Anh): ");
                            eng = Console.ReadLine();
                            b2.remove(eng);break;
                        }
                    case 6:
                        Console.WriteLine(  " Xin chào và hẹn gặp lại !");break;
                    default:
                        Console.WriteLine("Bạn chọn sai lựa chọn .Mời chọn lại: ");
                        break;
                }
            } while (chose!=6);
        }


    }
}
