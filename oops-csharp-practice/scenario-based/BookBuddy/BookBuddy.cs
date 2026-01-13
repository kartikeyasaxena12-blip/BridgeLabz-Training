using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.BookBuddy
{
    class BookBuddy : IBook
    {
        private Book[] books = new Book[10];
        int count = 0;
        public BookBuddy()
        {
            addBook("Atomic Habits", "James Clear");
            addBook("The Alchemist", "Paulo Coelho");
            addBook("Clean Code", "Robert Martin");
            addBook("Rich Dad Poor Dad", "Robert Kiyosaki");
            addBook("Deep Work", "Cal Newport");
        }

        public void addBook(String title, String author)
        {
            if (count >= 10)
            {
                Console.WriteLine("Sorry, Bookshelf Full");
                return;
            }

            books[count] = new Book(title, author);
            count++;
        }

        public void searchByAuthor(string author)
        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                string[] parts = books[i].GetBookData().Split('-');
                string bookAuthor = parts[1].Trim();

                if (bookAuthor.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(books[i].GetBookData());
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No books found for this author");
            }
        }

        public void sortBooksAlphabetically()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (string.Compare(
                        books[i].GetBookData(),
                        books[j].GetBookData(),
                        true) > 0)
                    {
                        Book temp = books[i];
                        books[i] = books[j];
                        books[j] = temp;
                    }
                }
            }
            Console.WriteLine("Books Sorted Alphabetically");
        }

        public void displayBooks()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(books[i].GetBookData());
            }
        }
    }
}
