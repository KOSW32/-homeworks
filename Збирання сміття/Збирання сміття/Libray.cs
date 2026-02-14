using System;

public class Library : IDisposable
{
    private Book[] books;
    private int count;

    public Library(int capacity)
    {
        books = new Book[capacity];
        count = 0;
        Console.WriteLine("Бібліотека створена");
    }

    public void AddBook(Book book)
    {
        if (count < books.Length)
        {
            books[count] = book;
            count++;
        }
    }

    public void ShowBooks()
    {
        Console.WriteLine("Книги в бібліотеці:");
        for (int i = 0; i < count; i++)
        {
            books[i].ShowInfo();
        }
    }

    public void Dispose()
    {
        Console.WriteLine("Dispose викликано для бібліотеки");

        for (int i = 0; i < count; i++)
        {
            books[i]?.Dispose();
        }

        books = null;
        GC.SuppressFinalize(this);
    }

    ~Library()
    {
        Console.WriteLine("Фіналізатор бібліотеки викликано");
    }
}
