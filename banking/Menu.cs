using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    internal class Menu
    {
        public void menu()
        {
            Console.WriteLine("Welcome to the Danske Bank!");
            Console.WriteLine("Are you a customer or an employee?");
            Console.WriteLine("Enter 1 for 'customer' or 2 for 'employee':");
        }

        public static List<Customers> customers = new List<Customers>();
        public static List<Account> accounts = new List<Account>();
        public static List<Employee> employees = new List<Employee>();

        static void Menu_m(string[] args)
        {
            Menu menu = new Menu();
            Customers_M customer_Menu = new Customers_M();
            Employee_M employee_Menu = new Employee_M();
           
        }
    }
}
