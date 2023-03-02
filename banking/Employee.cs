using banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    internal class Employee : person
    {
        public List<Customers> Customer { get; set; }

        public Employee(string name, string password)
        {
            Name = name;
            Password = password;
            Customer = new List<Customers>();
        }

        public void create_CUSTOMER()
        {
            // Show list of all customers
            Console.Write("\nEnter customer name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter customer email: ");
            string customerEmail = Console.ReadLine();

            Console.Write("Enter customer password: ");
            string customerPassword = Console.ReadLine();



            CreateCustomer(customerName, customerEmail, customerPassword);
        }




        public void CreateCustomer(string name, string email, string password)
        {
            Customer.Add(new Customers(name, email, password));

        }


        public void ViewCustomers()
        {
            Console.WriteLine("Customers:");

            foreach (Customers customer in Customer)
            {
                Console.WriteLine($"\n{customer.Name}");

            }

            Console.ReadLine();
        }




        public void create_ACCOUNT()
        {
            // Show list of all customers
            Console.Write("\nChoose customer to make account for: ");
            ViewCustomers();

            string CustomerNR = Console.ReadLine();

            Console.Write("Enter balance amount: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            CreateAccount(CustomerNR, balance);

        }

        private void CreateAccount(string customerNR, decimal balance)
        {
            throw new NotImplementedException();
        }

        public void CreateAccount(Customers customer, decimal balance)
        {
            customer.Accounts.Add(new Account(customer, balance));
        }

    }
}
