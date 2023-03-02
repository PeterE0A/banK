using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banks
{
    class Customer : Person
    {
        
           
            public List<Account> Accounts { get; set; }

            public Customer( string name, string email, string password)
            {
                Name = name;
                Email = email;
                Password = password;
                Accounts = new List<Account>();
            }



        public void ShowOverview()
        {

            Console.WriteLine("Here are your accounts:");

            foreach (Account account in Accounts)
            {
                Console.WriteLine($"\n{account.AccountNumber} Name: {account.Customer.Name}\nAccount Balance: {account.Balance}\n");

            }

            Console.ReadLine();
        }



        public void TransferMoney()
        {
            Console.WriteLine("Enter the account number to transfer from:");
            int fromAccountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the account number to transfer to:");
            int toAccountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount to transfer:");
            //decimal amount = decimal.Parse(Console.ReadLine());
            decimal amount = decimal.Parse(Console.ReadLine());

            //Account fromAccount = Data.accounts.Find(a => a.AccountNumber == fromAccountNumber);
            //Account toAccount = Data.accounts.Find(a => a.AccountNumber == toAccountNumber);

            Account fromAccount = Program.accounts.Find(a => a.AccountNumber == fromAccountNumber);
            Account toAccount = Program.accounts.Find(a => a.AccountNumber == toAccountNumber);

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



        public void deposit_money()
        {
            Console.WriteLine("Enter the account number to Deposit to:");
            int toAccountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount to Deposit:");
            decimal amount = decimal.Parse(Console.ReadLine());


            //Account toAccount = Data.accounts.Find(a => a.AccountNumber == toAccountNumber);


            Account toAccount = Program.accounts.Find(a => a.AccountNumber == toAccountNumber);

            toAccount.Deposit(amount);
            Console.WriteLine("Deposit complete!");
            Console.ReadLine();
        }


        public void withdraw_money()
        {

            Console.WriteLine("Enter the account number to withdraw from:");
            int fromAccountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount to withdraw:");
            decimal amount = decimal.Parse(Console.ReadLine());


            //Account toAccount = Data.accounts.Find(a => a.AccountNumber == fromAccountNumber);

            Account toAccount = Program.accounts.Find(a => a.AccountNumber == fromAccountNumber);

            toAccount.Withdraw(amount);
            Console.WriteLine("Withdrawal complete!");
            Console.ReadLine();
        }




    }


}

