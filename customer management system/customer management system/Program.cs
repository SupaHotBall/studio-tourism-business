using System;

namespace customer_management_system
{
    internal partial class Program
    {
        private const string CorrectPassword = "forstaffonly";

        static void Main(string[] args)
        {
            Authentication();
        }

        public static void Menu()
        {
            int userInput;
            string temp;

            Console.WriteLine("Main Menu\n");

            Console.WriteLine("1. Display customer details");
            Console.WriteLine("2. Add customer details");
            Console.WriteLine("3. Update customer details");
            Console.WriteLine("4. Remove customer details");

            Console.WriteLine("5. View bookings");
            Console.WriteLine("6. Add a booking");
            Console.WriteLine("7. Update booking");
            Console.WriteLine("8. Delete booking");

            Console.WriteLine("9. View monthly expenses");
            Console.WriteLine("10. Add a new expense");

            Console.WriteLine("11. Change system password");

            Console.WriteLine("Type the number of the feature you would like to use and hit Enter");

            do
            {
                temp = Console.ReadLine();
                userInput = Convert.ToInt32(temp);

                switch (userInput)
                {
                    case 1:

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

        public static void Authentication()
        {
            Console.WriteLine("Welcome to the Password Authentication System!");

            do
            {
                Console.Write("Enter the password: ");
                string enteredPassword = Console.ReadLine();

                if (enteredPassword == CorrectPassword)
                {
                    Console.WriteLine("Authentication successful. Welcome!");
                    Menu();
                    break;  
                }
                else
                {
                    Console.WriteLine("Authentication failed. Please try again.");
                }
            } while (true);  

        }
    }
}
