using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class assignment_3
    {
        static void Main(string[] args)
        {
            int n;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("Nhập vào độ dài của mảng để tính tổng các số lẻ: ");
                n = int.Parse(Console.ReadLine());
                if (n > 100 || n <= 0)
                {
                    Console.WriteLine("Độ dài của mảng số nguyên phải <=100. Mời nhập lại !");
                }
            } while (n>100||n<=0);
            int[] arr=new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" Nhập vào số nguyên thứ {0}: ",i+1);
                arr[i]=int.Parse (Console.ReadLine());  
            }
            int s=0;// tong
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2!=0)
                {
                    s += arr[i];
                }
            }
            Console.WriteLine(" Tổng của Các số lẻ là :{0} ",s);

        }
    }
}
