using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banks
{
    class Employee : Person
    {
        public List<Customer> Customers { get; set; }

        public Employee(string name, string password)
        {
            Name = name;
            Password = password;
            Customers = new List<Customer>();
        }

        public void ViewCustomers()
        {
            Console.WriteLine("Customers:");

            foreach (Customer customer in Customers)
            {
                Console.WriteLine(customer.Name);

            }
        }

        public void create_CUSTOMER()
        {
            // Show a list of all customers
            Console.Write("\nEnter customer name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter customer email: ");
            string customerEmail = Console.ReadLine();

            Console.Write("Enter customer password: ");
            string customerPassword = Console.ReadLine();


            CreateCustomer(customerName, customerEmail, customerPassword);
        }




        public void CreateCustomer(string name, string email, string password)
        {
            Customers.Add(new Customer(name, email, password));

        }


        public void create_ACCOUNT()
        {
            // Show a list of all customers
            Console.Write("\nChoose customer to make account for: ");
            ViewCustomers();

            string CustomerNR =Console.ReadLine();

            Console.Write("Enter balance amount: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            Employee employee = Data.employees.Find(e => e.Name == CustomerNR);

            employee.CreateAccount(CustomerNR, balance);



        }

        private void CreateAccount(string customerNR, decimal balance)
        {
            throw new NotImplementedException();
        }

        public void CreateAccount(Customer customer, decimal balance)
        {
            customer.Accounts.Add(new Account(customer, balance));
        }
    }
}
