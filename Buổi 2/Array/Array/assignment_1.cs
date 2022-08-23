using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class assignment_1
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            int n;
            do
            {
                Console.WriteLine("Mời nhập vào độ dài của mảng số nguyên: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n<0||n>50)
                {
                    Console.WriteLine("Độ dài của mảng phải lớn hơn 0 và nhỏ hơn 50 \n Mời nhập lại !");
                }
            } while (n<0||n>50);
         
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Nhập vào giá trị của số nguyên thứ {0}: ", i+1);// in ra màn hình
                arr[i]=Convert.ToInt32(Console.ReadLine());   // gán giá trị từ bàn phím vào phần tử của mảng.
            }
            Console.WriteLine("Dãy trước khi sắp xếp: ");
            for (int i = 0; i <arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            for (int i = 0; i <arr.Length-1; i++)// phần tử cần nổi
            {
                for (int j = i+1; j < arr.Length; j++)// số phần tử cần so sánh để nối
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;  
                    }
                }
            }
            Console.WriteLine("\n Hàm sau khi sắp xếp. ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
