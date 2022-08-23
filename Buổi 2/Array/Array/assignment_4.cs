using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class assignment_4
    {
        static void Main(string[] args)
        {
            int n;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("Nhập vào độ dài của mảng để đếm số các số âm có trong mảng: ");
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
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    count   ++; 
                }
            }
            Console.WriteLine("Dãy trên có {0} số ấm ở trong dãy. ",count);
        }
    }
}
