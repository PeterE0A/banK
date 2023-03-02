using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banks
{
    class Data
    {

        public static List<Customer> customers = new List<Customer>();
        public static List<Account> accounts = new List<Account>();
        public static List<Employee> employees = new List<Employee>();

         public void FakeData()
        {
            customers.Add(new Customer("Peter", "peter@gmail.com", "password123"));
            customers.Add(new Customer("Bob", "bob@gmail.com", "password456"));
            accounts.Add(new Account(customers[0], 1000));
            accounts.Add(new Account(customers[1], 500));
            employees.Add(new Employee("admin", "adminpassword"));

          

        }
    }
}
