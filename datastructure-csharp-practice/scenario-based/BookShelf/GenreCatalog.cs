using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.BookShelf
{
    public class GenreCatalog
    {
        private Dictionary<string, IBook> genreMap = new Dictionary<string, IBook>();

        public GenreCatalog()
        {
            AddDefaultBooks();
        }

        private void AddDefaultBooks()
        {
            AddBook("Fiction", new BookShelf("1984", "George Orwell"));
            AddBook("Fiction", new BookShelf("The Alchemist", "Paulo Coelho"));

            AddBook("Science", new BookShelf("Cosmos", "Carl Sagan"));
            AddBook("Science", new BookShelf("A Brief History of Time", "Stephen Hawking"));
        }

        public void AddBook(string genre, BookShelf book)
        {
            if (!genreMap.ContainsKey(genre))
            {
                genreMap[genre] = new BookUtility();
            }
            genreMap[genre].AddBook(book);
        }

        public void BorrowBook(string genre, string title)
        {
            if (genreMap.ContainsKey(genre))
            {
                genreMap[genre].RemoveBook(title);
            }
            else
            {
                Console.WriteLine("Genre not found");
            }
        }

        public void DisplayCatalog()
        {
            foreach (var item in genreMap)
            {
                Console.WriteLine("\nGenre: " + item.Key);
                item.Value.DisplayBooks();
            }
        }
    }
}