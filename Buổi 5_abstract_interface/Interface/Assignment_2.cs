using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_IVehicle
{
    internal class Assignment_2
    {
        List<Vehicles> listVehicles;

        public Assignment_2()
        {
            listVehicles = new List<Vehicles>();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
        }

        static void Menu(out int select)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. input");
            Console.WriteLine("2. Display all");
            Console.WriteLine("3. Sort by price.");
            Console.WriteLine("4. Search by model");
            Console.WriteLine("5. Exit program.");
            Console.WriteLine("Enter number from 1 to 5.");
            select = int.Parse(Console.ReadLine());
        }
        static void SubMenu(out int chose)
        {
            Console.WriteLine("1. Input Car");
            Console.WriteLine("2. Input Struct");
            chose = int.Parse(Console.ReadLine());
        }

       
        static void DisplayAll(List <Vehicles> listIV)
        {
            for(int i = 0; i < listIV.Count; i++)
            {
            listIV[i].Display();
            }
        }

        static void SortByPrice(ref List<Vehicles> listIV)
        {
            
            for (int i = 0; i < listIV.Count; i++)
            {
                for (int j = i+1; j < listIV.Count; j++)
                {
                    if (listIV[i].Price > listIV[j].Price)
                    {
                        Vehicles temp = listIV[i];
                        listIV[i] = listIV[j];
                        listIV[j] = temp;
                    }
                }
            }
        }

        static int SearchByModel(string model, List<Vehicles> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] != null)
                {
                    if (list[i].Model.Equals(model))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Assignment_2 b2= new Assignment_2();
            
            int select, chose;
            do
            {
                Menu(out select);
                switch (select)
                {
                    case 1:
                        SubMenu(out chose);
                        if(chose == 1)
                        {
                            Car car = new Car();
                            car.Input();
                            b2.listVehicles.Add(car);
                            Console.WriteLine("Thêm đối tượng thành công.");
                            break;
                        }else if(chose == 2)
                        {
                            Truck truck = new Truck();
                            truck.Input();
                            b2.listVehicles.Add(truck);
                            Console.WriteLine("Thêm đối tượng thành công.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Đã thoát trình nhập.");
                            break;
                        }
                    case 2:
                        Console.WriteLine("List of Vehicles entered. ");
                        Console.WriteLine("------------------------------------");
                        DisplayAll(b2.listVehicles);
                        Console.WriteLine("------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("List Vehicles before sort");
                        Console.WriteLine("------------------------------------");
                        DisplayAll(b2.listVehicles);
                        Console.WriteLine("------------------------------------");
                        SortByPrice(ref b2.listVehicles);
                        Console.WriteLine("List Vehicles after sort.");
                        Console.WriteLine("------------------------------------");
                        DisplayAll(b2.listVehicles);
                        Console.WriteLine("------------------------------------");
                        break;
                    case 4:
                        Console.WriteLine("Enter the model you are looking for: ");
                        string model = Console.ReadLine();
                        Console.WriteLine("------------------------------------");
                        int result = SearchByModel(model, b2.listVehicles);
                        if (result >= 0)
                        {
                            Console.WriteLine("Information you need to find.");
                           b2. listVehicles[result].Display();
                            break;
                        }
                        else if(result == -1)
                        {
                            Console.WriteLine("Model not found in the list.");
                            break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Goodbye.1");
                        break ;
                    default:
                        Console.WriteLine("Enter number from 1 to 5.");
                        break;
                }
            } while (select != 5);
        }
    }
}
