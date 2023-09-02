using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.IO;

namespace customer_management_system
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            string temp;

            Console.WriteLine("Main Menu\n");

            Console.WriteLine("1. Display customer details");
            Console.WriteLine("2. Add customer details");
            Console.WriteLine("3. Update customer details");
            Console.WriteLine("4. Remove customer details\n");

            Console.WriteLine("5. View bookings");
            Console.WriteLine("6. Add a booking");
            Console.WriteLine("7. Update booking");
            Console.WriteLine("8. Delete booking\n");

            Console.WriteLine("9. View monthly expenses");
            Console.WriteLine("10. Add a new expense\n");

            Console.WriteLine("11. Change system password\n");

            Console.WriteLine("Type the number of the feature you would like to use and hit Enter");

           do
            {
                temp = Console.ReadLine();
                userInput = Convert.ToInt32(temp);

                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        DisplayCustomerDetails();

                        break;

                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    case 9:

                        break;
                    case 10:

                        break;
                    case 11:

                        break;
                    default:
                        Console.WriteLine("Please enter a valid number and try again");
                        break;
                }

            } while (userInput < 1 || userInput > 11);




        }

        public static void DisplayCustomerDetails()
        {
            List<Customer> customers = new List<Customer>();            

            string[] lines = File.ReadAllLines("CustomerDetails.txt");

            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                if (fields.Length == 5)
                {
                    string firstName = fields[0];
                    string lastName = fields[1];
                    string address = fields[2];
                    string phoneNumber = fields[3];
                    string allergies = fields[4];

                    Customer newCustomer = new Customer(firstName, lastName, address, phoneNumber, allergies);
                    customers.Add(newCustomer);

                }

            }

             Console.WriteLine("Customer Details:\n");

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"First Name: {customer.FirstName}");
                Console.WriteLine($"Last Name: {customer.LastName}");
                Console.WriteLine($"Address: {customer.Address}");
                Console.WriteLine($"Phone Number: {customer.PhoneNumber}");
                Console.WriteLine($"Allergies: {customer.Allergies}");

            }
        }
    }
}
