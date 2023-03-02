using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace banks
{
    class Program
    {


        static void Main(string[] args)
        {
            Main_menu menu = new Main_menu();
            Customer_Menu customer_Menu = new Customer_Menu();
            Employee_Menu employee_Menu = new Employee_Menu();
        


            while (true)
            {


                menu.menu();


                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        customer_Menu.Customer_MENU();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        employee_Menu.Employee_MENU();
                        Console.Clear();
                        break;
                  

                }

            }
            
        }
    }
}

