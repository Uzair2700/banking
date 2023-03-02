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
        static void Main(string[] args)
        {

            // Create customers, accounts and employees for testing.
            customers.Add(new Customers("Uzi", "uzi@gmail.com", "pass1234"));
            customers.Add(new Customers("Lars", "Lars@live.dk", "pass2700"));
            accounts.Add(new Account(customers[0], 10000));
            accounts.Add(new Account(customers[1], 300));
            employees.Add(new Employee("admin", "password1234"));



            while (true)
            {
                // Prompt the user to log in as a customer or employee
                Console.WriteLine("Welcome to the Danske Bank!");
                Console.WriteLine("Are you a customer or an employee?");
                Console.WriteLine("Enter 1 for 'customer' or 2 for 'employee':");
                int userType = int.Parse(Console.ReadLine());
                
                Console.Clear();

                if (userType == 1)
                {
                    // Sign in as a customer
                    Console.WriteLine("Enter your email address:");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    string password = Console.ReadLine();

                    // Find the customer with the given email
                    Customers customer = customers.Find(c => c.Email == email && c.Password == password);

                    Console.Clear();

                    // Check if password is correct
                    if (customer != null && customer.Password == password)
                    {
                        // Show the customer's account and allow them to transfer money
                        Console.WriteLine($"Welcome, {customer.Name}!");

                        while (true)
                        {
                            Console.WriteLine("What do you want to do?");
                            Console.WriteLine("1. Show account overview");
                            Console.WriteLine("2. Transfer money");
                            Console.WriteLine("3. Deposit money");
                            Console.WriteLine("4. Withdraw money");
                            Console.WriteLine("5. Exit");
                            int choice = int.Parse(Console.ReadLine());

                            if (choice == 1)
                            {
                                Console.WriteLine("Here are your accounts:");
                                foreach (Account account in accounts)
                                {
                                    if (account.Customer == customer)
                                    {
                                        account.ShowOverview();
                                    }
                                   Console.ReadLine();
                                }

                                customer.ShowOverview();
                            }

                            else if (choice == 2)
                            {

                                Console.WriteLine("Enter the account number to transfer from:");
                                int fromAccountNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter the account number to transfer to:");
                                int toAccountNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter the amount of money to transfer:");
                                decimal amount = decimal.Parse(Console.ReadLine());


                                Account fromAccount = accounts.Find(a => a.AccountNumber == fromAccountNumber && a.Customer == customer);
                                Account toAccount = accounts.Find(a => a.AccountNumber == toAccountNumber);

                                if (fromAccount != null && toAccount != null)
                                {
                                    fromAccount.Withdraw(amount);
                                    toAccount.Deposit(amount);
                                    Console.WriteLine("Transfer complete!");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Invalid account numbers.");
                                    Console.ReadLine();
                                }

                            }

                            else if (choice == 3)
                            {
                                Account toAccount = accounts.Find(a => a.AccountNumber == a.Balance);
                                Console.WriteLine("Enter amount to deposit:");

                                decimal amount1 = decimal.Parse(Console.ReadLine());
                                toAccount.Deposit(amount1);




                            }

                            else if (choice == 4)
                            {

                            }

                            else if (choice == 5)
                            {
                                break;
                            }

                        }
                    }


                    else
                    {
                        Console.WriteLine("Invalid email or password. Please try again.");
                    }

                }

                else if (userType == 2)
                {
                    // Sign in as an employee
                    Console.WriteLine("Enter your name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    string password = Console.ReadLine();

                    Console.Clear();

                    // Find the employee with the given name
                    Employee employee = employees.Find(e => e.Name == name && e.Password == password);

                    // Check if the password is correct
                    if (employee != null && employee.Password == password)
                    {
                        // Show employee's options
                        Console.WriteLine($"Welcome, {employee.Name}!");

                        while (true)
                        {
                            Console.WriteLine("What do you want to do?");
                            Console.WriteLine("1. View customers");
                            Console.WriteLine("2. Create customer");
                            Console.WriteLine("3. Create account");
                            Console.WriteLine("4. Exit");
                            int option = int.Parse(Console.ReadLine());


                            if (option == 1)
                            {
                                // Show list of all customers
                                Console.WriteLine("Customers:");

                                employee.ViewCustomers();

                            }

                            else if (option == 2)
                            {

                                Console.Write("\nEnter customer name: ");
                                string customerName = Console.ReadLine();

                                Console.Write("Enter customer email: ");
                                string customerEmail = Console.ReadLine();

                                Console.Write("Enter customer password: ");
                                string customerPassword = Console.ReadLine();


                                employee.CreateCustomer(customerName, customerEmail, customerPassword);
                            }

                            else if (option == 3)
                            {


                               

                            }

                            else if (option == 4)
                            {
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
    }
}
