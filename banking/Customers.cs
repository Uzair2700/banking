using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    internal class Customers : person
    {
        public List<Account> Accounts { get; set; }

        public Customers(string name, string email, string password)
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
                Console.WriteLine($"\n{account.AccountNumber} Name: {account.Customer.Name}\nAccount Balance: {account.Balance}\n");
            }
        }

        public void TransferMoney(Account fromAccount, Account toAccount, decimal amount)
        {
            fromAccount.Withdraw(amount);
            toAccount.Deposit(amount);

        }
    }
}