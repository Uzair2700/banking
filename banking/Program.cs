using banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace banks
{
    class Program
    {


        static List<Customers> customers = new List<Customers>();
        static List<Account> accounts = new List<Account>();
        static List<Employee> employees = new List<Employee>();

        public static List<Customers> customer = new List<Customers>();
        public static List<Account> account = new List<Account>();
        public static List<Employee> employee = new List<Employee>();

        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Customers_M customer_Menu = new Customers_M();
            Employee_M employee_Menu = new Employee_M();

            customers.Add(new Customers("Uzi", "uzi@gmail.com", "pass2700"));
            customers.Add(new Customers("Lars", "lars@live.com", "pass1000"));
            accounts.Add(new Account(customers[0], 10000));
            accounts.Add(new Account(customers[1], 400));
            employees.Add(new Employee("admin", "admin1234"));


            while (true)
            {

                menu.menu();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        customer_Menu.Customer_M();
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        employee_Menu.Employee_MENU();
                        Console.Clear();
                        break;

                }
            }
        }
    }
}
