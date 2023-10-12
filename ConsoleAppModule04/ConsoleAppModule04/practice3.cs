using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Title} - {Author} ({Year})";
    }
}

class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public List<Book> FindBooksByAuthor(string author)
    {
        return books.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Book> FindBooksByYear(int year)
    {
        return books.Where(book => book.Year == year).ToList();
    }

    public void SortBooksByTitle()
    {
        books.Sort((book1, book2) => string.Compare(book1.Title, book2.Title, StringComparison.OrdinalIgnoreCase));
    }

    public void SortBooksByAuthor()
    {
        books.Sort((book1, book2) => string.Compare(book1.Author, book2.Author, StringComparison.OrdinalIgnoreCase));
    }

    public void SortBooksByYear()
    {
        books.Sort((book1, book2) => book1.Year.CompareTo(book2.Year));
    }

    public void DisplayAllBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}

class practice3
{
    static void Main()
    {
        Library myLibrary = new Library();

        myLibrary.AddBook(new Book("Война и мир", "Лев Толстой", 1869));
        myLibrary.AddBook(new Book("Преступление и наказание", "Федор Достоевский", 1866));
        myLibrary.AddBook(new Book("1984", "Джордж Оруэлл", 1949));

        Console.WriteLine("Список всех книг в библиотеке:");
        myLibrary.DisplayAllBooks();

        Console.WriteLine("\nПоиск книг по автору 'Лев Толстой':");
        var tolstoyBooks = myLibrary.FindBooksByAuthor("Лев Толстой");
        foreach (var book in tolstoyBooks)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nСортировка книг по названию:");
        myLibrary.SortBooksByTitle();
        myLibrary.DisplayAllBooks();

        Console.ReadKey();
    }
}