using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banks
{
    class Employee_Menu
    {
        //public List<Customer> customers { get; set; }
       // public List<Account> accounts { get; set; }
        public List<Employee> employees { get; set; }
        public void Employee_MENU()
        {
            //Actions action = new Actions();

            // Log in as an employee
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            // Find the customer with the given email address
            //Customer customer = Data.customers.Find(e => e.Name == name && e.Password == password);
            //Account account = Data.accounts.Find(e => e.Name == name && e.Password == password);
            //Employee employee = Data.employees.Find(e => e.Name == name && e.Password == password);


            //Customer customer = Program.customers.Find(e => e.Name == name && e.Password == password);
            //Account account = Program.accounts.Find(e => e.Name == name && e.Password == password);
            Employee employee = Program.employees.Find(e => e.Name == name && e.Password == password);

            if (employee != null && employee.Password == password)
            {
                Console.WriteLine($"Welcome, {employee.Name}!");

                while (true)
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. View customers");
                    Console.WriteLine("2. Create customer");
                    Console.WriteLine("3. Create account");
                    Console.WriteLine("4. Exit");

                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.D1:
                            employee.ViewCustomers();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad2:
                        case ConsoleKey.D2:
                            employee.create_CUSTOMER();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad3:
                        case ConsoleKey.D3:
                            employee.create_ACCOUNT();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad4:
                        case ConsoleKey.D4:
                            Environment.Exit(0);
                            Console.Clear();
                            break;

                    }



                }


            }
            else
            {
                Console.WriteLine("Invalid name or password. Please try again.");
            }


        }
    }
}
