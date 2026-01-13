using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.BookBuddy
{
    class Menu
    {
        public void Display()
        {
            IBook book = new BookBuddy();

            bool exit = true;

            while (exit)
            {
                Console.WriteLine("\nEnter 1 to add book");
                Console.WriteLine("Enter 2 to sort books");
                Console.WriteLine("Enter 3 to search books");
                Console.WriteLine("Enter 4 to display all books");
                Console.WriteLine("Enter 5 to exit");
                Console.WriteLine("\nEnter choice");

                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter title");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter author");
                        string author = Console.ReadLine();
                        book.addBook(title, author);
                        break;

                    case 2:
                        book.sortBooksAlphabetically();
                        break;

                    case 3:
                        Console.WriteLine("Enter author name");
                        string search = Console.ReadLine();
                        book.searchByAuthor(search);
                        break;

                    case 4:
                        book.displayBooks();
                        break;

                    case 5:
                        exit = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
