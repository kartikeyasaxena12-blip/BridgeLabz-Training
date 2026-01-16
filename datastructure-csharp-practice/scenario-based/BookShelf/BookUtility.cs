using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.BookShelf
{
    public class BookUtility : IBook
    {
        private LinkedList<BookShelf> books = new LinkedList<BookShelf>();

        public void AddBook(BookShelf book)
        {
            books.AddLast(book);
        }

        public void RemoveBook(string book)
        {
            var current = books.First;

            while (current != null)
            {
                if (current.Value.GetTitle().Equals(book))
                {
                    books.Remove(current);
                    Console.WriteLine("Book borrowed");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Book not found");
        }

        public void DisplayBooks()
        {
            foreach (BookShelf book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}

