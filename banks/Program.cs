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
        public static List<Customer> customers = new List<Customer>();
        public static List<Account> accounts = new List<Account>();
        public static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            Main_menu menu = new Main_menu();
            Customer_Menu customer_Menu = new Customer_Menu();
            Employee_Menu employee_Menu = new Employee_Menu();

            customers.Add(new Customer("Peter", "peter@gmail.com", "password123"));
            customers.Add(new Customer("Bob", "bob@gmail.com", "password456"));
            accounts.Add(new Account(customers[0], 1000));
            accounts.Add(new Account(customers[1], 500));
            employees.Add(new Employee("admin", "adminpassword"));



        


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

