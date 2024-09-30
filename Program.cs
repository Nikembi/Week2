using Newtonsoft.Json;
using Week2.Entities;
using Week2.Exceptions;

namespace Week2
{
    internal class Program
    {
        static bool exit;
        static List<Contacts> contactsList = new List<Contacts>();
        static void Main(string[] args)
        {

            while (!exit)
            {
                DisplayMenu();
            }
           
        }
        static void DisplayMenu()
        {
            Console.WriteLine($"Options{Environment.NewLine}");
            Console.WriteLine("1. Search Contacts");
            Console.WriteLine("2. Add New Contact");
            Console.WriteLine("3. Contacts & Phonebook");
            Console.WriteLine("4. Save Contact");
            Console.WriteLine($"5. Exit{Environment.NewLine}");
            Console.Write("Choose an Option: ");
            
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
                        SaveContacts();
                        break;
                    case 5:
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
            Console.Write("First Name: ");
            string firstName = Console.ReadLine().Trim();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine().Trim();

            Console.Write("Country Code (e.g., +1): ");
            string countryCode = Console.ReadLine().Trim();

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine().Trim();

            // Construct the complete phone number
            string completePhoneNumber = $"+{countryCode}{phoneNumber}";
            bool InvalidPhoneNumber = false;
            while (!InvalidPhoneNumber)
            {
                
                try
                {
                    contactsList.Add(new Contacts
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        PhoneNumber = completePhoneNumber

                    });
                    foreach (new Contacts in contactsList)
                    {
                        
                    }
                    if (int.TryParse(countryCode, out int countryCodeint))
                    {

                    }
                    if (countryCode.Length > 3 || countryCode.Length < 1)
                    {
                        Console.Write("Enter a valid Country Code");
                    }
                }
                catch( InvalidNumberExceptions e)
                {
                    
                }
            }
        }
        static void SaveContacts()
        {   
            string folderPath = "C:\\Users\\gloga\\Documents";
            string FileName = "contactlist.json";
            
            string path = Path.Combine(folderPath, FileName);
            string json = JsonConvert.SerializeObject(contactsList);

            File.WriteAllText(FileName, json);
            Console.WriteLine($"Contact saved successfully to {path}!");
        }
        //static void PhoneBook()
        //{
        //    while (!exit)
        //    {
        //        Console.WriteLine($"Select an option{Environment.NewLine}");
        //        Console.WriteLine("1. ");
        //    }
        //}
        static void Exit()
        {
            exit = true;
            Console.WriteLine($"{Environment.NewLine}Good Bye! Press any key to exit.");
            Console.ReadKey();
        }
    }
}