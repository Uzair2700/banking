using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    internal class Data
    {
        public static List<Customers> customers = new List<Customers>();
        public static List<Account> accounts = new List<Account>();
        public static List<Employee> employees = new List<Employee>();

        public void FakeData()
        {
            customers.Add(new Customers("Uzi", "uzi@gmail.com", "pass2700"));
            customers.Add(new Customers("Lars", "lars@live.com", "pass1000"));
            accounts.Add(new Account(customers[0], 10000));
            accounts.Add(new Account(customers[1], 400));
            employees.Add(new Employee("admin", "admin1234"));
        }
    }
}
