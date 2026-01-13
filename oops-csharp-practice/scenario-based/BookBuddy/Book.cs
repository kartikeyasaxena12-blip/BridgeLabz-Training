using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.BookBuddy
{
    internal class Book
    {
        private string bookData;

        public Book(string title, string author)
        {
            bookData = title + " - " + author;
        }

        public string GetBookData()
        {
            return bookData;
        }
    }
}
