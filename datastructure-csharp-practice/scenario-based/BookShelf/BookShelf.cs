using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.BookShelf
{
    public class BookShelf
        {
            private string title;
            private string author;

            public BookShelf(string title, string author)
            {
                this.title = title;
                this.author = author;
            }

            public string GetTitle()
            {
                return title;
            }

            public string GetAuthor()
            {
                return author;
            }

            public override string ToString()
            {
                return title + " by " + author;
            }

        }
    }
