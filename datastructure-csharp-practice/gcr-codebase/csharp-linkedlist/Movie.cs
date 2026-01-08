using System;

class MovieNode
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public MovieNode next;
    public MovieNode prev;

    public MovieNode(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        next = null;
        prev = null;
    }
}

class MovieDoublyLinkedList
{
    MovieNode head;

    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);

        if (head != null)
        {
            newNode.next = head;
            head.prev = newNode;
        }
        head = newNode;
    }

    public void AddAtEnd(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);

        if (head == null)
        {
            head = newNode;
            return;
        }

        MovieNode temp = head;
        while (temp.next != null)
            temp = temp.next;

        temp.next = newNode;
        newNode.prev = temp;
    }

    public void AddAtPosition(string title, string director, int year, double rating, int position)
    {
        if (position == 1)
        {
            AddAtBeginning(title, director, year, rating);
            return;
        }

        MovieNode temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
            temp = temp.next;

        if (temp == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        MovieNode newNode = new MovieNode(title, director, year, rating);
        newNode.next = temp.next;
        newNode.prev = temp;

        if (temp.next != null)
            temp.next.prev = newNode;

        temp.next = newNode;
    }

    public void RemoveByTitle(string title)
    {
        MovieNode temp = head;

        while (temp != null && temp.Title != title)
            temp = temp.next;

        if (temp == null)
        {
            Console.WriteLine("Movie not found");
            return;
        }

        if (temp.prev != null)
            temp.prev.next = temp.next;
        else
            head = temp.next;

        if (temp.next != null)
            temp.next.prev = temp.prev;

        Console.WriteLine("Movie removed");
    }

    public void SearchByDirector(string director)
    {
        MovieNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Director == director)
            {
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.next;
        }

        if (!found)
            Console.WriteLine("No movies found");
    }

    public void SearchByRating(double rating)
    {
        MovieNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Rating == rating)
            {
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.next;
        }

        if (!found)
            Console.WriteLine("No movies found");
    }

    public void UpdateRating(string title, double newRating)
    {
        MovieNode temp = head;

        while (temp != null)
        {
            if (temp.Title == title)
            {
                temp.Rating = newRating;
                Console.WriteLine("Rating updated");
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("Movie not found");
    }

    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("No movies available");
            return;
        }

        MovieNode temp = head;
        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.next;
        }
    }

    public void DisplayReverse()
    {
        if (head == null)
        {
            Console.WriteLine("No movies available");
            return;
        }

        MovieNode temp = head;
        while (temp.next != null)
            temp = temp.next;

        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.prev;
        }
    }

    void DisplayMovie(MovieNode m)
    {
        Console.WriteLine("Title: " + m.Title +", Director: " + m.Director +", Year: " + m.Year +", Rating: " + m.Rating);
    }
}

class Program
{
    static void Main()
    {
        MovieDoublyLinkedList list = new MovieDoublyLinkedList();
        int choice;

        do
        {
            Console.WriteLine("\n--- Movie Management System ---");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Remove by Title");
            Console.WriteLine("5. Search by Director");
            Console.WriteLine("6. Search by Rating");
            Console.WriteLine("7. Display Forward");
            Console.WriteLine("8. Display Reverse");
            Console.WriteLine("9. Update Rating");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            string title, director;
            int year, position;
            double rating;

            switch (choice)
            {
                case 1:
                    Console.Write("Title: ");
                    title = Console.ReadLine();
                    Console.Write("Director: ");
                    director = Console.ReadLine();
                    Console.Write("Year: ");
                    year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Rating: ");
                    rating = Convert.ToDouble(Console.ReadLine());
                    list.AddAtBeginning(title, director, year, rating);
                    break;

                case 2:
                    Console.Write("Title: ");
                    title = Console.ReadLine();
                    Console.Write("Director: ");
                    director = Console.ReadLine();
                    Console.Write("Year: ");
                    year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Rating: ");
                    rating = Convert.ToDouble(Console.ReadLine());
                    list.AddAtEnd(title, director, year, rating);
                    break;

                case 3:
                    Console.Write("Position: ");
                    position = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Title: ");
                    title = Console.ReadLine();
                    Console.Write("Director: ");
                    director = Console.ReadLine();
                    Console.Write("Year: ");
                    year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Rating: ");
                    rating = Convert.ToDouble(Console.ReadLine());
                    list.AddAtPosition(title, director, year, rating, position);
                    break;

                case 4:
                    Console.Write("Movie Title: ");
                    title = Console.ReadLine();
                    list.RemoveByTitle(title);
                    break;

                case 5:
                    Console.Write("Director Name: ");
                    director = Console.ReadLine();
                    list.SearchByDirector(director);
                    break;

                case 6:
                    Console.Write("Rating: ");
                    rating = Convert.ToDouble(Console.ReadLine());
                    list.SearchByRating(rating);
                    break;

                case 7:
                    list.DisplayForward();
                    break;

                case 8:
                    list.DisplayReverse();
                    break;

                case 9:
                    Console.Write("Movie Title: ");
                    title = Console.ReadLine();
                    Console.Write("New Rating: ");
                    rating = Convert.ToDouble(Console.ReadLine());
                    list.UpdateRating(title, rating);
                    break;
            }

        } while (choice != 0);
    }
}
