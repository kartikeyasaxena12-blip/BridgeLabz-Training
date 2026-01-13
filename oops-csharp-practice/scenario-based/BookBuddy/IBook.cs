using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.BookBuddy
{
    interface IBook
    {
        void addBook(String title, String author);
        void sortBooksAlphabetically();
        void searchByAuthor(String author);
        void displayBooks();
    }
}
