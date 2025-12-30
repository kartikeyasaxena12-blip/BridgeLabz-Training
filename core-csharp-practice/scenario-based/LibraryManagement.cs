using System;
class LibraryManagement
{
    static void Main(string[]args)//main function
    {
        string[,] books =
        {
            { "C Sharp Programming", "Herbert Schildt", "Available" },
            { "Data Structures", "Mark Allen Weiss", "Available" },
            { "Operating Systems", "Silberschatz", "Available" },
            { "Database Management", "Korth", "Available" }
        };//2d array to store books

        LibraryManagement obj= new LibraryManagement();

        Console.WriteLine("Enter Role  Admin   User");//enter role
        string role=Console.ReadLine().ToLower();

        if (role == "admin")
        {
            Console.WriteLine("Enter Password:");//enter password
            int pass = Convert.ToInt32(Console.ReadLine());

            if (pass != 2345)
            {
                Console.WriteLine("Wrong password");
                return; 
            }
        }

        while(true)
        {
            Console.WriteLine("\n--- Library Menu ---");
            if (role == "admin")//functions admin can perform
            {
                Console.WriteLine("1. Display Books");
                Console.WriteLine("2. Add Book");
                Console.WriteLine("4. Exit");
                int ch= Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                    {
                        obj.Display(books);//calling methods
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Enter book title:");
                        string t = Console.ReadLine();
                        Console.WriteLine("Enter author:");
                        string a = Console.ReadLine();
                        books = obj.AddBook(books, t, a);
                        Console.WriteLine("Book added successfully");
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Exit Successful");
                        Environment.Exit(0);
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid Choice");
                        break;
                    }
                }
                }
                

            else
            {
                //functions user can perform
                    Console.WriteLine("1. Display Books");
                    Console.WriteLine("2. Search Book");
                    Console.WriteLine("3. Checkout Book");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter choice: ");

                    int choice= Convert.ToInt32(Console.ReadLine());//enter choice
                    switch(choice)
                    {
                        case 1:
                        {
                            obj.Display(books);
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine("Enter book to search");
                            string str=Console.ReadLine();
                            obj.Search(books,str);
                            break;
                        }
                        case 3:
                        {
                            Console.WriteLine("Enter Title of the Book you want to buy");
                            string title = Console.ReadLine();
                            obj.CheckOut(books,title);   
                            break;
                        }
                        case 4:
                        {
                            Console.WriteLine("Exit Successful");
                            Environment.Exit(0);
                            break;
                        }
                        default://if enter wrong choice
                        {
                            Console.WriteLine("Invalid Choice");
                            break;
                        }
                    }
                }
        }
        
    }

    //to display all books
    void Display(string[,] books)
    {
        Console.WriteLine("\nTitle | Author | Status");
        for(int i=0;i<books.GetLength(0);i++)
        {
            Console.WriteLine(books[i,0]+" | "+books[i,1]+" | "+books[i,2]);
        }
    }

    //to search books
    void Search(string[,] books,string str)
    {
        int found=0;
        for(int i=0;i<books.GetLength(0);i++)
        {
            if (books[i, 0].ToLower().Contains(str.ToLower()))// substring is present in title
            {
                Console.WriteLine(books[i,0]+" | "+books[i,1]+" | "+books[i,2]);//print details of book
                found=1;
            }
        }
        if(found==0)
        Console.WriteLine("No book found");
    }

    // to successfully checkout the book
    void CheckOut(string[,] books, string str)
    {
        for(int i = 0; i < books.GetLength(0); i++)
        {
            if(books[i, 0].ToLower().Contains(str.ToLower()))
            {
                if(books[i,2] == "Available")//if book available
                {
                    books[i,2] = "Checked Out";//update the status
                    Console.WriteLine("Book CheckedOut Successfully "+ books[i,0]);
                }
                else
                {
                    Console.WriteLine("Book Not Available");//if book is already checkedout
                }
            }

        }
    }

    //method to add book
    string[,] AddBook(string[,] books, string title, string author)
    {
        int rows = books.GetLength(0);
        string[,] newBooks = new string[rows + 1, 3];//new array to store books

        for (int i = 0; i < rows; i++)
        {
            newBooks[i, 0] = books[i, 0];
            newBooks[i, 1] = books[i, 1];
            newBooks[i, 2] = books[i, 2];
        }
        newBooks[rows, 0] = title;// adding new book
        newBooks[rows, 1] = author;
        newBooks[rows, 2] = "Available";

        return newBooks;
    }

}