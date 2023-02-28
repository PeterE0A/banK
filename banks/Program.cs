using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banks
{
    class Program
    {


        static List<Customer> customers = new List<Customer>();
        static List<Account> accounts = new List<Account>();
        static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
         

            // Create some customers, accounts, and employees for testing purposes
            customers.Add(new Customer("Peter", "peter@gmail.com", "password123"));
            customers.Add(new Customer("Bob", "bob@gmail.com", "password456"));
            accounts.Add(new Account(customers[0], 1000));
            accounts.Add(new Account(customers[1], 500));
            employees.Add(new Employee("admin", "adminpassword"));

            // Prompt the user to log in as a customer or employee
            Console.WriteLine("Welcome to the Panama Bank!");
            Console.WriteLine("Are you a customer or an employee?");
            Console.WriteLine("Enter 1 for 'customer' or 2 for 'employee':");
            int userType = int.Parse(Console.ReadLine());





            if (userType == 1)
            {
                // Log in as a customer
                Console.WriteLine("Enter your email address:");
                string email = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                string password = Console.ReadLine();

                // Find the customer with the given email address
                Customer customer = customers.Find(c => c.Email == email);




                // Check if the password is correct
                if (customer != null && customer.Password == password)
                {
                    // Show the customer's accounts and allow them to transfer money
                    Console.WriteLine($"Welcome, {customer.Name}!");
                    Console.WriteLine("Press 1 to View Account or 2 to Transfer money");
                    int choice = int.Parse(Console.ReadLine());




                    if (choice == 1)
                    {
                        Console.WriteLine("Here are your accounts:");
                        foreach (Account account in accounts)
                        {
                            if (account.Customer == customer)
                            {
                                Console.WriteLine($"Account #{account.AccountNumber}: {account.Balance:C}");
                                Console.ReadLine();
                            }
                        }
                    }

                    else if (choice == 2)
                    {

                        Console.WriteLine("Enter the account number to transfer from:");
                        int fromAccountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the account number to transfer to:");
                        int toAccountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the amount to transfer:");
                        decimal amount = decimal.Parse(Console.ReadLine());


                        Account fromAccount = accounts.Find(a => a.AccountNumber == fromAccountNumber && a.Customer == customer);
                        Account toAccount = accounts.Find(a => a.AccountNumber == toAccountNumber);

                        if (fromAccount != null && toAccount != null)
                        {
                            fromAccount.Withdraw(amount);
                            toAccount.Deposit(amount);
                            Console.WriteLine("Transfer complete!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Invalid account numbers.");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid email or password.");
                        Console.ReadLine();
                    }


                }


            }
            else if (userType == 2)
            {
                // Log in as an employee
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                string password = Console.ReadLine();

                // Find the employee with the given name
                Employee employee = employees.Find(e => e.Name == name);

                // Check if the password is correct
                if (employee != null && employee.Password == password)
                {
                    // Show the employee's options
                    Console.WriteLine($"Welcome, {employee.Name}!");
                    Console.WriteLine("Enter '1' to view customers.");
                    Console.WriteLine("Enter '2' to create a customer.");
                    Console.WriteLine("Enter '3' to create an account.");

                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        // Show a list of all customers
                        Console.WriteLine("Customers:");
                        foreach (Customer customer in customers)
                        {
                            Console.WriteLine(customer.Name);
                        }
                        Console.ReadLine();


                    }
                    else if (option == 2)
                    {
                        // Show a list of all customers
                        Console.Write("\nEnter customer name: ");
                        string customerName = Console.ReadLine();

                        Console.Write("Enter customer email: ");
                        string customerEmail = Console.ReadLine();

                        Console.Write("Enter customer password: ");
                        string customerPassword = Console.ReadLine();

                        //Employee employee1 = employees.add(customerName, customerEmail, customerPassword);

                        Console.WriteLine("\nNew customer created!");


                       
                     


                        Console.ReadLine();
                    }
                }

            }



        }
    }
}

