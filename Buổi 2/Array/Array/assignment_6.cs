using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class assignment_6
    {
        static void Main(string[] args)
        {
            int n;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("Nhập vào độ dài của mảng để tìm số nhỏ nhất ở trong mảng: ");
                n = int.Parse(Console.ReadLine());
                if (n > 100 || n <= 0)
                {
                    Console.WriteLine("Độ dài của mảng số nguyên phải <=100. Mời nhập lại !");
                }
            } while (n > 100 || n <= 0);
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" Nhập vào số nguyên thứ {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(" Số lớn nhất ở trong mảng là: {0}", min);
        }
    }
}
