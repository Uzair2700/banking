using banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    internal class Employee_M
    {
        public List<Employee> Employees { get; set; }
        public void Employee_MENU()
        {
            Console.Clear();

            // sign in as an employee
            Console.WriteLine("Employee");
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            Employee employee = Program.employee.Find(e => e.Name == name && e.Password == password);

            if (employee != null && employee.Password == password)
            {
                Console.WriteLine($"Welcome, {employee.Name}!");

                while (true)
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. View customers");
                    Console.WriteLine("2. Create customer");
                    Console.WriteLine("3. Create account");
                    Console.WriteLine("4. Exit");

                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.D1:
                            employee.ViewCustomers();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad2:
                        case ConsoleKey.D2:
                            employee.create_CUSTOMER();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad3:
                        case ConsoleKey.D3:
                            employee.create_ACCOUNT();
                            Console.Clear();
                            break;
                        case ConsoleKey.NumPad4:
                        case ConsoleKey.D4:
                            Environment.Exit(0);
                            Console.Clear();
                            break;

                    }

                }

            }
            else
            {
                Console.WriteLine("Invalid name or password. Please try again.");
            }


        }
    }
}
