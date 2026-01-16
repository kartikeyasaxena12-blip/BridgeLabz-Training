using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.BookShelf
{
    internal interface IBook
    {
        void AddBook(BookShelf book);
        void RemoveBook(string title);
        void DisplayBooks();
    }
}
