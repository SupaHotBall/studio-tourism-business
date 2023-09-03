﻿using System;
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

           do
            {

                Console.Clear();
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

                userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        DisplayCustomerDetails();

                        break;

                    case 2:
                        Console.Clear();
                        AddCustomerDetails();

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

            } while (userInput != 0);




        }

        public static void DisplayCustomerDetails()
        {
            List<Customer> customers = new List<Customer>();            

            string[] lines = File.ReadAllLines("CustomerDetails.txt");

            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                if (fields.Length == 6)
                {
                    string customerID = fields[0];
                    string firstName = fields[1];
                    string lastName = fields[2];
                    string address = fields[3];
                    string phoneNumber = fields[4];
                    string allergies = fields[5];

                    Customer newCustomer = new Customer(customerID, firstName, lastName, address, phoneNumber, allergies);
                    customers.Add(newCustomer);

                }

            }

             Console.WriteLine("=============================== Customer Details ================================================ \n");
             Console.WriteLine("Customer ID".PadRight(15) + "FirstName".PadRight(15) + "LastName".PadRight(15) + "Address".PadRight(15) + "PhoneNumber".PadRight(15) + "Allergies\n".PadRight(15));

            foreach (Customer customer in customers)
            {
                Console.Write(customer.CustomerID.PadRight(15));
                Console.Write(customer.FirstName.PadRight(15));
                Console.Write(customer.LastName.PadRight(15));
                Console.Write(customer.Address.PadRight(15));
                Console.Write(customer.PhoneNumber.PadRight(15));
                Console.WriteLine(customer.Allergies.PadRight(15));
            }

            Console.WriteLine();
            Console.WriteLine("================================================================================================ \n");
            Console.WriteLine("Press Enter to return to the Main Menu");

            Console.ReadKey();
            Console.Clear();
        }

        public static void AddCustomerDetails()
        {
            string userInput;
            string userInput2;
            string userInput3;
            string userInput4;
            string userInput5;
            string userInputConfirm;  

            Console.WriteLine("==============================");
            Console.WriteLine("Enter customer's first name ==");
            userInput = Console.ReadLine();
            Console.WriteLine("Enter customer's last name ===");
            userInput2 = Console.ReadLine();
            Console.WriteLine("Enter customer's address =====");
            userInput3 = Console.ReadLine();
            Console.WriteLine("Enter customer's number ======");
            userInput4 = Console.ReadLine();
            Console.WriteLine("Enter customer's allergies ===");
            userInput5 = Console.ReadLine();
            Console.WriteLine("==============================\n");

            Console.WriteLine("Are you sure these details are correct? Enter Y or N.\n");
            userInputConfirm = Console.ReadLine();

            if (userInputConfirm == "Y")
            {

                using (StreamWriter sw = File.AppendText("CustomerDetails.txt"))
                {
                    sw.WriteLine($"{userInput},{userInput2},{userInput3},{userInput4},{userInput5}");
                }

                Console.WriteLine("\nCustomer details have been successfully added.");
                Console.WriteLine("Press Enter to return to the Main Menu.");

                Console.ReadKey();
                Console.Clear();

            }

            else
            {
                Console.WriteLine("\nCustomer details have not been added.");
                Console.WriteLine("Press Enter to return to the Main Menu.");

                Console.ReadKey();
                Console.Clear();
            }
            

        }

        public static void UpdateCustomerDetails()
        {
            string userInput;
            string userInput2;
            string userInput3;
            string userInput4;
            string userInput5;

            Console.WriteLine("==============================");
            Console.WriteLine("Update customer's first name ==");
            userInput = Console.ReadLine();
            Console.WriteLine("Update customer's last name ===");
            userInput2 = Console.ReadLine();
            Console.WriteLine("Update customer's address =====");
            userInput3 = Console.ReadLine();
            Console.WriteLine("Update customer's number ======");
            userInput4 = Console.ReadLine();
            Console.WriteLine("Update customer's allergies ===");
            userInput5 = Console.ReadLine();
            Console.WriteLine("==============================\n");

        }
    }
}
