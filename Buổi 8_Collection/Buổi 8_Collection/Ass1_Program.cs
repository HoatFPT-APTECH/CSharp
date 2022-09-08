using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Buổi_8_Collection
{
    internal class Ass1_Program
    {
    
        Dictionary<String, int> map;
        String line = null;
        String str;
        public Ass1_Program()
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
      
            map = new Dictionary<String, int>();  
        }
        public Boolean isStringEmty(String str)
        {
            return (str == null || str.Trim().Length==0)?true:false;
        }
        public int numberInArray(String str, String[] arr)
        {
            int count=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(str))
                {
                    count++;
                }
            }
            return count;
        }
      
        static void Main(string[] args)
        {
            Ass1_Program b1= new Ass1_Program();
            Console.WriteLine("Nhập vào các chuỗi bất kỳ (nhập trống để dừng): ");
         
            do
            {
              
                b1.str = Console.ReadLine();
                if (b1.isStringEmty(b1.str) == true)
                {
                    break;
                }
                else
                {
                    b1.line += " ";
                    b1.line += b1.str;
                }
            } while (true);
            String[] listStr = b1.line.Split(" ");
            int count;
            for (int i = 0; i < listStr.Length; i++)
            {
                 count = b1.numberInArray(listStr[i], listStr);
                if (b1.map.ContainsKey(listStr[i]) || listStr[i].Equals(""))continue;

                b1.map.Add(listStr[i],count);
            }
            Console.WriteLine("Số lượng phần tử ở trong dãy chuỗi đã nhập: ");
            foreach (KeyValuePair<String,int> e in b1.map)
            {
                Console.WriteLine(e.Key+" : "+e.Value);
            }
            
        }
    }
}
