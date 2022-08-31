using System;
namespace TinhLuongNV_abstract_interface
{
    class Program
    {
        List<NVKiThuat> NV_KyThuat;
        List<NVKinhdoanh> NV_KinhDoanh;

        public Program()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            NV_KinhDoanh= new List<NVKinhdoanh>();
            NV_KyThuat = new List<NVKiThuat>();
        }
        public int chonNV()
        {
            
            int chon;
            Console.WriteLine("Chọn loại nhân viên: \n 1. Nhân viên Kinh doanh \n 2.Nhân viên Kỹ thuật");
            chon=int.Parse(Console.ReadLine());
            return chon;
        }

        public int Menu()
        {
            int chon;
            Console.WriteLine("Menu: \n 1.Thêm Nhân viên \n 2.Hiển thị danh sách thông tin nhân viên.\n 3.Thoát");
            chon=int.Parse(Console.ReadLine());
            return chon;
        }
        static void Main(string[] args)
        {
            int chon;
            Program p= new Program();
            do
            {
                chon = p.Menu();
                switch (chon)
                {
                    case 1:
                        {
                            int chonNv;
                            do
                            {
                                 chonNv = p.chonNV();
                                switch (chonNv)
                                {
                                    case 1:
                                        {
                                            NVKinhdoanh nv = new NVKinhdoanh();
                                            nv.Nhap();
                                            p.NV_KinhDoanh.Add(nv);break;
                                        }
                                    case 2:
                                        {
                                            NVKiThuat nv= new NVKiThuat();
                                            nv.Nhap();
                                            p.NV_KyThuat.Add(nv);
                                            break;
                                        }

                                 default:
                                        Console.WriteLine("Bạn phải nhập lựa chọn tử 1->2. Mời chọn lại");
                                        break;
                                }
                            } while (chonNv!=1&& chonNv!=2);
                           
                            break;
                        }
                    case 2:
                        
                            {
                            int chonNv;
                                do
                                {
                                chonNv = p.chonNV();
                                switch (chonNv)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("Nhân viên kinh doanh: ");
                                                foreach (NVKinhdoanh element in p.NV_KinhDoanh)
                                                {
                                                    element.HienThi();
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.WriteLine("Nhân viên kỹ Thuật: ");
                                                foreach (NVKiThuat element in p.NV_KyThuat)
                                                {
                                                    element.HienThi();
                                                }
                                                break;
                                            }

                                        default:
                                            Console.WriteLine("Bạn phải nhập lựa chọn tử 1->2. Mời chọn lại");
                                            break;
                                    }
                                } while (chonNv != 1 && chonNv != 2);
                                break;
                            }
                    default :
                        Console.WriteLine("Bạn phải nhập lựa chọn tử 1->3. Mời chọn lại");break;
                      
                }

            } while (chon!=3);
        }
    }
}