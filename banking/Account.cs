using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
        class Account
        {


            private static int lastAccountNumber = 0;

            public int AccountNumber { get; private set; }
            public Customers Customer { get; set; }
            public decimal Balance { get; private set; }

            public Account(Customers customer, decimal balance)
            {
                AccountNumber = ++lastAccountNumber;
                Customer = customer;
                Balance = balance;
                customer.Accounts.Add(this);
            }

            public void Deposit(decimal amount)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C} to account #{AccountNumber}. New balance: {Balance:C}");
            }

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

            public void ShowOverview()
            {
                Console.WriteLine($"Account #{AccountNumber}: {Balance:C}");
            }
        }    
  
}
