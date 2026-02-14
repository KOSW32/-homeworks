using System;

public class Book : IDisposable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Pages { get; set; }

    public Book(string title, string author, int year, int pages)
    {
        Title = title;
        Author = author;
        Year = year;
        Pages = pages;

        Console.WriteLine($"Книга \"{Title}\" створена");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Назва: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Рік: {Year}");
        Console.WriteLine($"Сторінок: {Pages}");
        Console.WriteLine();
    }

    // IDisposable
    public void Dispose()
    {
        Console.WriteLine($"Dispose викликано для книги \"{Title}\"");
        GC.SuppressFinalize(this);
    }

    // Финализатор
    ~Book()
    {
        Console.WriteLine($"Фіналізатор викликано для книги \"{Title}\"");
    }
}
