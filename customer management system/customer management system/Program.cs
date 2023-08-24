using System;
using System.ComponentModel.DataAnnotations;

namespace customer_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter what display you want to be: ");
                input = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("1. Tours information");
                Console.WriteLine("2. Items to rent");
                Console.WriteLine("1. Calendar");
                Console.WriteLine("2. Adding customer to a calender");
                Console.WriteLine("3. Removing customer to a calender");
                Console.WriteLine("")

                switch (input)
                {
                    case "1":
                        Display();
                        break;

                    case "2":
                        Task2();
                        break;

                    case "3":
                        Task3();
                        break;

                    case "4":
                        Task4();
                        break;

                    case "5":
                        Task5();
                        break;

                    case "6":
                        Task6();
                        break;

                    case "7":
                        Task7();
                        break;

                    case "n":
                        Console.WriteLine("Exiting the display");
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 1 to 10 or n for quit");
                        break;
                }
                Console.WriteLine();

            } while (input != "n");
        }
        public void Display()
        {

        }
    }
}
