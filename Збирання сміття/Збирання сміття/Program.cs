using System;

class Program
{
    static void Main()
    {
        using (Library library = new Library(3))
        {
            Book b1 = new Book("1984", "George Orwell", 1949, 328);
            Book b2 = new Book("Kobzar", "Taras Shevchenko", 1840, 256);

            library.AddBook(b1);
            library.AddBook(b2);

            library.ShowBooks();
        }

        Console.WriteLine("\nВикликаємо GC...");
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Кінець програми");
    }
}
