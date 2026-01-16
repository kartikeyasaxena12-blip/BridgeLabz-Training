using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.BookShelf
{
    public class Menu
    {
        private GenreCatalog catalog = new GenreCatalog();

        public void Display()
        {
            bool exit = true;

            while (exit)
            {
                Console.WriteLine("\n------ Library Menu ------");
                Console.WriteLine("1. Display Library Catalog");
                Console.WriteLine("2. Add Book");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        catalog.DisplayCatalog();
                        break;
                    case 2:
                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();

                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Author Name: ");
                        string author = Console.ReadLine();

                        catalog.AddBook(genre, new BookShelf(title, author));
                        break;

                    case 3:
                        Console.WriteLine("Enter Genre: ");
                        string genreB = Console.ReadLine();
                        Console.WriteLine("Enter Title");
                        string titleB = Console.ReadLine();

                        catalog.BorrowBook(genreB, titleB);
                        break;

                    case 4:
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