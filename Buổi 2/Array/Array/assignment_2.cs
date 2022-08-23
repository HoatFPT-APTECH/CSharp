using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class assignment_2
    {

        void n_le( ref double [] arr)
        {

            int n = arr.Length;
            int tg = n / 2;
            for (int i = 0; i < arr.Length/2; i++)
            {
                 if (i==tg)
                {
                    continue;
                }
                int j = n - i - 1;
                double temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
               
            }
       
        }
        static void Main(string[] args)
        {
            int n;
            assignment_2 as2 = new assignment_2();
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine(" Nhập vào độ dài của mảng cần đảo chiều phần tử: ");
                n= Convert.ToInt32(Console.ReadLine());
                if (n > 100 || n <= 0)
                {
                    Console.WriteLine(" Độ dài của mảng phải <=100 .\n Mời bạn nhập lại !");
                }
            } while ( n >100||n<=0);
            double[] arr = new double[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Nhập vào giá trị của số nguyên thứ {0}: ", i + 1);// in ra màn hình
                arr[i] = Convert.ToDouble(Console.ReadLine());   // gán giá trị từ bàn phím vào phần tử của mảng.
            }
            Console.WriteLine("Mảng trước khi đảo chiều: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            
             as2.n_le(ref arr);
            Console.WriteLine(" \n Mảng sau khi đảo chiều: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            
        }
    }
}
