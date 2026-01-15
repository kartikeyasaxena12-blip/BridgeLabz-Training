using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.AddressBook
{
    internal class AddressBook : IAddressBook
    {
        private Contact[] contacts = new Contact[50];
        private int count = 0;


        public AddressBook() // to add data by default
        {
            AddDefaultContacts();
        }

        private void AddDefaultContacts()
        {
            Contact c1 = new Contact
            {
                FirstName = "Rahul",
                LastName = "Sharma",
                Address = "MG Road",
                City = "Bangalore",
                State = "Karnataka",
                Zip = "560001",
                PhoneNumber = "9876543210",
                Email = "rahul@gmail.com"
            };

            Contact c2 = new Contact
            {
                FirstName = "Anita",
                LastName = "Verma",
                Address = "Nehru Nagar",
                City = "Delhi",
                State = "Delhi",
                Zip = "110001",
                PhoneNumber = "9123456780",
                Email = "anita@gmail.com"
            };
            contacts[count++] = c1;
            contacts[count++] = c2;
        }

        // To add contact
        public void AddContact()
        {
            if (count >= contacts.Length)
            {
                Console.WriteLine("Address Book is Full\n");
                return;
            }

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            if (IsDuplicate(firstName, lastName))
            {
                Console.WriteLine("Duplicate entry! Contact already exists.\n");
                return;
            }

            Contact contact = new Contact
            {
                FirstName = firstName,
                LastName = lastName
            };

            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter State: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            contact.Email = Console.ReadLine();

            contacts[count++] = contact;

            Console.WriteLine("Contact Added Successfully\n");
        }



        // Edit contact by first name
        public void EditContact()
        {
            Console.Write("Enter First Name to Edit: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName == name)
                {
                    Console.Write("Enter New Address: ");
                    contacts[i].Address = Console.ReadLine();

                    Console.Write("Enter New City: ");
                    contacts[i].City = Console.ReadLine();

                    Console.Write("Enter New State: ");
                    contacts[i].State = Console.ReadLine();

                    Console.Write("Enter New Zip: ");
                    contacts[i].Zip = Console.ReadLine();

                    Console.Write("Enter New Phone Number: ");
                    contacts[i].PhoneNumber = Console.ReadLine();

                    Console.Write("Enter New Email: ");
                    contacts[i].Email = Console.ReadLine();

                    Console.WriteLine("Contact Updated Successfully\n");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found\n");
        }

        // Delete contact by first name
        public void DeleteContact()
        {
            Console.Write("Enter First Name to Delete: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName == name)
                {
                    for (int j = i; j < count - 1; j++)
                        contacts[j] = contacts[j + 1];

                    contacts[count - 1] = null;
                    count--;

                    Console.WriteLine("Contact Deleted Successfully\n");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found\n");
        }

        public void DisplayAllContacts()
        {
            if (count == 0)
            {
                Console.WriteLine("No contacts available\n");
                return;
            }

            Console.WriteLine("\n--- Contacts in Address Book: ");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Name    : " + contacts[i].FirstName + " " + contacts[i].LastName);
                Console.WriteLine("Address : " + contacts[i].Address);
                Console.WriteLine("City    : " + contacts[i].City);
                Console.WriteLine("State   : " + contacts[i].State);
                Console.WriteLine("Zip     : " + contacts[i].Zip);
                Console.WriteLine("Phone   : " + contacts[i].PhoneNumber);
                Console.WriteLine("Email   : " + contacts[i].Email);
            }

            Console.WriteLine("--------------------------------\n");
        }

        // To check for duplicate
        private bool IsDuplicate(string firstName, string lastName) 
        {
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    contacts[i].LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public void SearchPersonByCity()
        {
            Console.Write("Enter City to Search: ");
            string city = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].City.Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayContact(contacts[i]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No person found in this city.\n");
            }
        }

        public void SearchPersonByState()
        {
            Console.Write("Enter State to Search: ");
            string state = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].State.Equals(state, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayContact(contacts[i]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No person found in this state.\n");
            }
        }

        private void DisplayContact(Contact contact)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Name    : " + contact.FirstName + " " + contact.LastName);
            Console.WriteLine("Address : " + contact.Address);
            Console.WriteLine("City    : " + contact.City);
            Console.WriteLine("State   : " + contact.State);
            Console.WriteLine("Zip     : " + contact.Zip);
            Console.WriteLine("Phone   : " + contact.PhoneNumber);
            Console.WriteLine("Email   : " + contact.Email);
        }


        public void CountContactsByCity()
        {
            Console.Write("Enter City to Search: ");
            string city = Console.ReadLine();

            int cityCount = 0;

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].City.Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    cityCount++;
                }
            }

            if (cityCount > 0)
            {
                Console.WriteLine($"Number of contacts in city '{city}' : {cityCount}\n");
            }
            else
            {
                Console.WriteLine("No contacts found in this city.\n");
            }
        }

        public void CountContactsByState()
        {
            Console.Write("Enter State to Search: ");
            string state = Console.ReadLine();

            int stateCount = 0;

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].State.Equals(state, StringComparison.OrdinalIgnoreCase))
                {
                    stateCount++;
                }
            }

            if (stateCount > 0)
            {
                Console.WriteLine($"Number of contacts in state '{state}' : {stateCount}\n");
            }
            else
            {
                Console.WriteLine("No contacts found in this state.\n");
            }
        }



    }
}
