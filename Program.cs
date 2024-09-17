using System;

namespace Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                DisplayMenu();
            }
           
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Search Contacts");
            Console.WriteLine("2. Create Contact");
            Console.WriteLine("3. View Contacts/PhoneBook");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int menuOption))
            {
                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("You selected: Search Contacts");
                        break;
                    case 2:
                        Console.WriteLine("You selected: Create Contact");
                        break;
                    case 3:
                        Console.WriteLine("You selected: View Contacts/PhoneBook");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}