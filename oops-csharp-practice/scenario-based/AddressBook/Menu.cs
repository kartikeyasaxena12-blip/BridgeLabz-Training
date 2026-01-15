using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.AddressBook
{
    internal class Menu
    {
        private AddressBook addressBook = new AddressBook();

        public void DisplayMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Address Book Menu ---");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Display All Contacts");
                Console.WriteLine("5. Search Person by City");
                Console.WriteLine("6. Search Person by State");
                Console.WriteLine("7. Count Contacts by City");
                Console.WriteLine("8. Count Contacts by State");
                Console.WriteLine("0. Exit");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressBook.AddContact();
                        break;

                    case 2:
                        addressBook.EditContact();
                        break;

                    case 3:
                        addressBook.DeleteContact();
                        break;

                    case 4:
                        addressBook.DisplayAllContacts();
                        break;

                    case 5:
                        addressBook.SearchPersonByCity();
                        break;

                    case 6:
                        addressBook.SearchPersonByState();
                        break;

                    case 7:
                        addressBook.CountContactsByCity();
                        break;

                    case 8:
                        addressBook.CountContactsByState();
                        break;


                    case 0:
                        Console.WriteLine("Program Ended");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 0);
        }
    }
}
