using banks;
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
            Console.WriteLine("Here is all your accounts");

            foreach (Account account in Accounts)
            {
                Console.WriteLine($"\n{account.AccountNumber} Name: {account.Customer.Name}\nAccount Balance: {account.Balance}\n");
            }
        }

        public void TransferMoney()
        {
            Console.WriteLine("Enter the account number to transfer from:");
            int fromAccount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the account number to transfer to:");
            int toAccount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount to transfer:");
            decimal amount = decimal.Parse(Console.ReadLine());

            Account fromaccount = Program.account.Find(a => a.AccountNumber == fromAccount);
            Account toaccount = Program.account.Find(a => a.AccountNumber == toAccount);

            if (fromAccount != null && toAccount != null)
            {
                fromaccount.Withdraw(amount);
                toaccount.Deposit(amount);
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

            Account toAccount = Program.account.Find(a => a.AccountNumber == toAccountNumber);

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

            Account toAccount = Program.account.Find(a => a.AccountNumber == fromAccountNumber);

            toAccount.Withdraw(amount);
            Console.WriteLine("Withdrawal complete!");
            Console.ReadLine();
        }

    }
}