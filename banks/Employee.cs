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
            foreach (Customer customer in Customers)
            {
                Console.WriteLine(customer.Name);

            }
        }

        public void CreateCustomer(string name, string email, string password)
        {
            Customers.Add(new Customer(name, email, password));

        }

        public void CreateAccount(Customer customer, decimal balance)
        {
            customer.Accounts.Add(new Account(customer, balance));
        }
    }
}
