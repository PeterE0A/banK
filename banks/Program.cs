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



            while (true)
            {
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
                    Customer customer = customers.Find(c => c.Email == email && c.Password == password);




                    // Check if the password is correct
                    if (customer != null && customer.Password == password)
                    {
                        // Show the customer's accounts and allow them to transfer money
                        Console.WriteLine($"Welcome, {customer.Name}!");

                        while (true)
                        {
                            Console.WriteLine("What would you like to do?");
                            Console.WriteLine("1. Show account overview");
                            Console.WriteLine("2. Transfer money");
                            Console.WriteLine("3. Deposit money");
                            Console.WriteLine("4. Withdraw money");
                            Console.WriteLine("5. Exit");
                            int choice = int.Parse(Console.ReadLine());

                            if (choice == 1)
                            {
                                Console.WriteLine("Here are your accounts:");
                                //foreach (Account account in accounts)
                                //{
                                //    if (account.Customer == customer)
                                //    {
                                //        account.ShowOverview();
                                //    }
                                //    Console.ReadLine();
                                //}

                                customer.ShowOverview();
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


                            else if (choice == 3)
                            {
                                //to be continued

                                //Account toAccount = accounts.Find(a => a.AccountNumber == a.Balance);
                                //Console.WriteLine("Enter amount to deposit:");
                                // //decimal amount = decimal.Parse(Console.ReadLine());

                                //decimal amount1 = decimal.Parse(Console.ReadLine());
                                // toAccount.Deposit(amount1);
                                Console.WriteLine("Enter the account number to Deposit to:");
                                int toAccountNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter the amount to Deposit:");
                                decimal amount = decimal.Parse(Console.ReadLine());


                                Account toAccount = accounts.Find(a => a.AccountNumber == toAccountNumber);

                                toAccount.Deposit(amount);
                                Console.WriteLine("Deposit complete!");
                                Console.ReadLine();

                            }

                            else if (choice == 4)
                            {
                                //Console.WriteLine("Enter amount to withdraw:");
                                //if (!decimal.TryParse(Console.ReadLine(), out amount))
                                //{
                                //    Console.WriteLine("Invalid amount.");
                                //    break;
                                //}
                                //customer.Account.Withdraw(amount);
                                //break;

                                Console.WriteLine("Enter the account number to withdraw from:");
                                int fromAccountNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter the amount to withdraw:");
                                decimal amount = decimal.Parse(Console.ReadLine());


                                Account toAccount = accounts.Find(a => a.AccountNumber == fromAccountNumber);

                                toAccount.Withdraw(amount);
                                Console.WriteLine("Withdrawal complete!");
                                Console.ReadLine();

                            }

                            else if (choice == 5)
                            {
                                break;
                            }

                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid email or password. Please try again.");
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
                    Employee employee = employees.Find(e => e.Name == name && e.Password == password);

                    // Check if the password is correct
                    if (employee != null && employee.Password == password)
                    {
                        // Show the employee's options
                        Console.WriteLine($"Welcome, {employee.Name}!");

                        while (true)
                        {
                            Console.WriteLine("What would you like to do?");
                            Console.WriteLine("1. View customers");
                            Console.WriteLine("2. Create customer");
                            Console.WriteLine("3. Create account");
                            Console.WriteLine("4. Exit");
                          int option = int.Parse(Console.ReadLine());


                            if (option == 1)
                            {
                                // Show a list of all customers
                                Console.WriteLine("Customers:");
                                //foreach (Customer customer in customers)
                                //{

                                //    customer.ShowOverview();


                                //}
                                //Console.ReadLine();
                                employee.ViewCustomers();

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

                          
                                employee.CreateCustomer(customerName, customerEmail, customerPassword);
                            }

                                else if (option == 3)
                                {


                                //Console.Write("\nChoose Customer: ");
                                //Customer customer = Console

                                //Console.Write("Enter the starting balance for the account: ");
                                //decimal balance = int.Parse(Console.ReadLine());

                                //Customer customer = ChooseCustomer(employee.Customers);
                                //    decimal balance = GetDecimalFromUser("Enter the starting balance for the account: ");

                                   //employee.CreateAccount(customer, balance);

                                }

                            else if (option == 4)
                            {
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
    }
}

