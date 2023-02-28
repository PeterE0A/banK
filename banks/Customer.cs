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
                foreach (Account account in Accounts)
                {
                    account.ShowOverview();
                }
            }

            public void TransferMoney(Account fromAccount, Account toAccount, decimal amount)
            {
                fromAccount.Withdraw(amount);
                toAccount.Deposit(amount);
            }
        
    }


}

