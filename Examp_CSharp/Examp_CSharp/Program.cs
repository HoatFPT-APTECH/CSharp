using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examp_CSharp
{
    internal class Program
    {
         public static Product[] list = new Product[5];
        static void Main(string[] args)
        {
            list[0] = new Book("SK4", "JAVA", 23.11);

            list[1] = new Book("SK5", "CSharp", 44.11);

            list[2] = new Book("SK6", "ISA", 23.11);

            list[3] = new Phone("PM", "BPHONE", 1000);
            list[4] = new Phone("QK", "IPHONE", 2000);
            
            Console.WriteLine("Display all the object in Array: ");
            Console.WriteLine("ID         NAME        PRICE        COMPUTE TAX");
            Console.WriteLine("-----------------------------------------------");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i].Id+"         "+list[i].Name+"        " + list[i].Price+"        " + list[i].computeTax());
            }
        }
    }
}
