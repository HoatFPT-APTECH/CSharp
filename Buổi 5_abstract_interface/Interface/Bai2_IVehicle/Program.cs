using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_IVehicle
{
    internal class Program
    {
       
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

       
        static void DisplayAll(IVehicle[] listIV)
        {
            for(int i = 0; i < listIV.Length; i++)
            {
               if(listIV[i] != null) listIV[i].Display();
            }
        }

        static void SortByPrice(Vehicles[] listIV)
        {
            Vehicles temp = new Vehicles();
            for(int i = 0; i < listIV.Length - 1; i++)
            {
                for(int j = 0; j < listIV.Length - 1 - j; j++)
                {
                   
                    if (listIV[j + 1] != null && listIV[j] != null)
                    {
                        if (listIV[j + 1].Price > listIV[j].Price)
                        {
                            temp = listIV[j + 1];
                            listIV[j + 1] = listIV[j];
                            listIV[j] = temp;
                        }
                    }
                }
            }
        }

        static int SearchByModel(string model, Vehicles[] list)
        {
            for(int i = 0; i < list.Length; i++)
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
            Vehicles[] listVehicles = new Vehicles[20];
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
                            for(int i = 0; i < 20; i++)
                            {
                                if (listVehicles[i] == null)
                                {
                                    listVehicles[i] = car;
                                    break;
                                }
                            }
                            break;
                        }else if(chose == 2)
                        {
                            Truck truck = new Truck();
                            truck.Input();
                            for (int i = 0; i < 20; i++)
                            {
                                if (listVehicles[i] == null)
                                {
                                    listVehicles[i] = truck;
                                    break;
                                }
                            }
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
                        DisplayAll(listVehicles);
                        Console.WriteLine("------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("List Vehicles before sort");
                        Console.WriteLine("------------------------------------");
                        DisplayAll(listVehicles);
                        Console.WriteLine("------------------------------------");
                        SortByPrice(listVehicles);
                        Console.WriteLine("List Vehicles after sort.");
                        Console.WriteLine("------------------------------------");
                        DisplayAll(listVehicles);
                        Console.WriteLine("------------------------------------");
                        break;
                    case 4:
                        Console.WriteLine("Enter the model you are looking for: ");
                        string model = Console.ReadLine();
                        Console.WriteLine("------------------------------------");
                        int result = SearchByModel(model, listVehicles);
                        if (result >= 0)
                        {
                            Console.WriteLine("Information you need to find.");
                            listVehicles[result].Display();
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
