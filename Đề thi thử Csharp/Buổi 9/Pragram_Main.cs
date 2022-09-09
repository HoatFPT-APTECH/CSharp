using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buổi_9
{
    internal class Pragram_Main
    {
        Dictionary<String, Products> list;

        public Pragram_Main()
        {
            list = new Dictionary<string, Products>();
        }
        public int Menu()
        {
            int chose;
            Console.Write("Menu:\r\no 1. Add product records\r\no 2. Display product records\r\no 3. Delete product by Id\r\no 4. Exit \n Enter the number: ");
            chose=int.Parse(Console.ReadLine());
            return chose;

        }
        public void add()
        {
            Console.WriteLine("The Fuction 1: ");
            Products p=new Products();
            BackInput:
            try
            {
                p.Input();
                this.list.Add(p.ID1 , p);
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: "+e.Message);
                goto BackInput;
            }
         
            Console.WriteLine("Add Procduct : Conglatulation.");
        }
        public void displayAll()
        {
            Console.WriteLine("The Fuction 2: ");
            Console.WriteLine("ID       Name        Price");
            Console.WriteLine("---------------------------");
            foreach(KeyValuePair<string, Products> item in list)
            {
                item.Value.display();
            }   
        }
        public void delete()
        {
            string id;
            Console.WriteLine("The Fuction 3: ");
            Console.WriteLine("Please Enter the ID of product to delete: ");
            id = Console.ReadLine();
            if(this.list.ContainsKey(id)==false)
                Console.WriteLine("Not found the Product have this ID ");
            else
            {
                string y;

                Console.WriteLine("Do you want delete the product have ID: "+id);
                y = Console.ReadLine();
                if (y.Equals("y"))
                {
                    this.list.Remove(id);
                    Console.WriteLine("this product is deleted.");
                }
               
            }
        }
        static void Main(string[] args)
        {
            Pragram_Main p =new Pragram_Main();
            int chose;
            do
            {
                chose = p.Menu();
                switch (chose)
                {
                    case 1:
                        {
                            p.add();
                            break;
                        }
                    case 2:
                        {
                            p.displayAll();
                            break;
                        }
                    case 3:
                        {
                            p.delete(); break;
                        }
                    case 4: Console.WriteLine("Good bye.");break;
                    default:
                        Console.WriteLine("Your chose is faile. Please Reenter the chose.");
                        break;
                }

            } while (chose!=4);
        }
    }
}
