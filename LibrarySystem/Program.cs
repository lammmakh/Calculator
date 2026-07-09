using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public int Year { get; set; }

}
class Program
{
    static List<Book> books = new List<Book>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Library Management System =====");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Show All Books");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. Delete Book");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                AddBook();
            }
            else if (choice == "2")
            {
                ShowBooks();
            }
            else if (choice == "3")
            {
                SearchBook();
            }
            else if (choice == "4")
            {
                DeleteBook();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    static void AddBook()
    {
        Console.Clear();
        Console.WriteLine("===== Add Book =====");

        Book book = new Book();

        Console.Write("Enter book title: ");
        book.Title = Console.ReadLine();

        Console.Write("Enter author name: ");
        book.Author = Console.ReadLine();

        Console.Write("Enter publishing year: ");
        book.Year = Convert.ToInt32(Console.ReadLine());

        books.Add(book);

        Console.WriteLine("Book added successfully.");
    }

    static void ShowBooks()
    {
        Console.Clear();
        Console.WriteLine("===== All Books =====");

        if (books.Count == 0)
        {
            Console.WriteLine("No books found.");
            return;
        }

        for (int i = 0; i < books.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + books[i].Title);
            Console.WriteLine("   Author: " + books[i].Author);
            Console.WriteLine("   Year: " + books[i].Year);
            Console.WriteLine();
        }
    }

    static void SearchBook()
    {
        Console.Clear();
        Console.WriteLine("===== Search Book =====");

        Console.Write("Enter book title to search: ");
        string searchTitle = Console.ReadLine();

        bool found = false;

        foreach (Book book in books)
        {
            if (book.Title.ToLower().Contains(searchTitle.ToLower()))
            {
                Console.WriteLine("\nBook Found:");
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Year: " + book.Year);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Book not found.");
        }
    }

    static void DeleteBook()
    {
        Console.Clear();
        Console.WriteLine("===== Delete Book =====");

        if (books.Count == 0)
        {
            Console.WriteLine("No books to delete.");
            return;
        }

        ShowBooks();

        Console.Write("Enter book number to delete: ");
        int bookNumber = Convert.ToInt32(Console.ReadLine());

        if (bookNumber >= 1 && bookNumber <= books.Count)
        {
            books.RemoveAt(bookNumber - 1);
            Console.WriteLine("Book deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid book number.");
        }
    }
}