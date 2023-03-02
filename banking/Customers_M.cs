using banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    internal class Customers_M
    {
        public List<Customers> customers { get; set; }



        public void Customer_M()
        {
            Console.Clear();


            Console.WriteLine("Customer");
            Console.WriteLine("Enter your email address:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();



            Customers customer = Program.customer.Find(c => c.Email == email && c.Password == password);
            

            if (customer != null && customer.Password == password)
            {
                Console.WriteLine($"Welcome, {customer.Name}!");

                while (true)
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Show account overview");
                    Console.WriteLine("2. Transfer money");
                    Console.WriteLine("3. Deposit money");
                    Console.WriteLine("4. Withdraw money");
                    Console.WriteLine("5. Exit");

                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.D1:
                            customer.ShowOverview();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad2:
                        case ConsoleKey.D2:
                            customer.TransferMoney();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad3:
                        case ConsoleKey.D3:
                            customer.deposit_money();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad4:
                        case ConsoleKey.D4:
                            customer.withdraw_money();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad5:
                        case ConsoleKey.D5:
                            Environment.Exit(0);
                            break;

                    }

                }

            }
            else
            {
                Console.WriteLine("Invalid email or password. Please try again.");
            }


        }
    }
}
