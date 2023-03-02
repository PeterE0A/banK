using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banks
{
    class Customer_Menu
    {
        public List<Customer> customers { get; set; }
        public List<Account> accounts { get; set; }
        public List<Employee> employees { get; set; }
        public void Customer_MENU()
        {
        //Actions action = new Actions();

            Console.WriteLine("Enter your email address:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            // Find the customer with the given email address
            Customer customer = customers.Find(c => c.Email == email && c.Password == password);
            Account account = accounts.Find(c => c.Email == email && c.Password == password);
            Employee employee = employees.Find(c => c.Email == email && c.Password == password);

            if (customer != null && customer.Password == password)
            {
                Console.WriteLine($"Welcome, {customer.Name}!");

                while (true)
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Show account overview");
                    Console.WriteLine("2. Transfer money");
                    Console.WriteLine("3. Deposit money");
                    Console.WriteLine("4. Withdraw money");
                    Console.WriteLine("5. Exit");

                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.D1:
                            customer.ShowOverview();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad2:
                        case ConsoleKey.D2:
                            customer.TransferMoney();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad3:
                        case ConsoleKey.D3:
                            account.deposit_money();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad4:
                        case ConsoleKey.D4:
                            account.withdraw_money();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad5:
                        case ConsoleKey.D5:
                            Environment.Exit(0);
                            break;

                    }



                }


            }
                 else
                {
                    Console.WriteLine("Invalid email or password. Please try again.");
                }


        }
    }
}
