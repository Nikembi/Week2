using System;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using Week2.Entities;

namespace Week2
{
    internal class Program
    {
        static bool exit;
        static List<Contacts> contacts;
        static void Main(string[] args)
        {

            while (!exit)
            {
                DisplayMenu();

            }
           
        }

        static void DisplayMenu()
        {
            Console.WriteLine($"Choose an option:{Environment.NewLine}");
            Console.WriteLine("1. Search Contacts");
            Console.WriteLine("2. Add New Contact");
            Console.WriteLine("3. Contacts & Phonebook");
            Console.WriteLine($"4. Exit{Environment.NewLine}");
            Console.Write("Choose Option: ");
            
            if (int.TryParse(Console.ReadLine(), out int menuOption))
            {
                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("You selected: Search Contacts");
                        break;
                    case 2:
                        Create();
                        break;
                    case 3:
                        Console.WriteLine("You selected: View Contacts/PhoneBook");
                        break;
                    case 4:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option.");
                        break;
                }
            }
        }
        static void Create()
        {
            Console.WriteLine($"New Contact{Environment.NewLine}-----------");
            contacts.Add
                (new Contacts
                {
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    PhoneNumber = Convert.ToInt32(Console.ReadLine())
                });
                
            
        }
        static void Exit()
        {
            exit = true;
            Console.WriteLine($"{Environment.NewLine}Good Bye! Press any key to exit.");
            Console.ReadKey();
        }
    }
}