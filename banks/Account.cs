using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banks
{
    class Account : Person
    {


        private static int lastAccountNumber = 0;

        public int AccountNumber { get; private set; }
        public Customer Customer { get; set; }
        public decimal Balance { get; private set; }

        public Account(Customer customer, decimal balance)
        {
            AccountNumber = ++lastAccountNumber;
            Customer = customer;
            Balance = balance;
            customer.Accounts.Add(this);
        }




        //public void deposit_money()
        //{
        //    Console.WriteLine("Enter the account number to Deposit to:");
        //    int toAccountNumber = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the amount to Deposit:");
        //    decimal amount = decimal.Parse(Console.ReadLine());


        //    //Account toAccount = Data.accounts.Find(a => a.AccountNumber == toAccountNumber);


        //    Account toAccount = Program.accounts.Find(a => a.AccountNumber == toAccountNumber);

        //    toAccount.Deposit(amount);
        //    Console.WriteLine("Deposit complete!");
        //    Console.ReadLine();
        //}

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} to account #{AccountNumber}. New balance: {Balance:C}");
        }


        //public void withdraw_money()
        //{

        //    Console.WriteLine("Enter the account number to withdraw from:");
        //    int fromAccountNumber = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the amount to withdraw:");
        //    decimal amount = decimal.Parse(Console.ReadLine());


        //    //Account toAccount = Data.accounts.Find(a => a.AccountNumber == fromAccountNumber);

        //    Account toAccount = Program.accounts.Find(a => a.AccountNumber == fromAccountNumber);

        //    toAccount.Withdraw(amount);
        //    Console.WriteLine("Withdrawal complete!");
        //    Console.ReadLine();
        //}

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from account #{AccountNumber}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds in account #{AccountNumber}. Current balance: {Balance:C}");
            }
        }




        //public void ShowOverview()
        //{
        //    Console.WriteLine($"Account #{AccountNumber}: {Balance:C}");
        //}
    }
}

