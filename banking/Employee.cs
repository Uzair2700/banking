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

        public void ViewCustomers()
        {
            foreach (Customers customer in Customer)
            {
                Console.WriteLine(customer.Name);

            }
        }

        public void CreateCustomer(string name, string email, string password)
        {
            Customer.Add(new Customers(name, email, password));

        }

        public void CreateAccount(Customers customer, decimal balance)
        {
            customer.Accounts.Add(new Account(customer, balance));

        }
    }
}
