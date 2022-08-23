using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_variable_if
{
    internal class mang2Chieu
    {
        static void Main(string[] args)
        {
            int[,] arr = 
            {
                {1,0,0,0,0 },
                {1,1,0,0,0},
                {1,1,1,0,0},
                {1,1,1,1,0 },
                { 1,1,1,1,1}
            };
            for (int i = 0; i < 6; i++)
            {
                for (int j= 0; j< 5; j++)
                {
                    if (arr[i,j]==1)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
