namespace Library.Domain.Entities;

using Library.Domain.ValueObjects;

public class Book
{
    public long Id { get; set; }

    public string Title { get; set; }

    public string Author { get; set; }

    public ISBN Isbn { get; set; }

    public bool Borrowed { get; set; }

    public Book(long id, string title, string author, ISBN isbn)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentNullException("Title cannot be empty.");

        if (string.IsNullOrWhiteSpace(author))
            throw new ArgumentNullException("Author cannot be empty");

        Id = id;
        Title = title;
        Author = author;
        Isbn = isbn;
        Borrowed = false;
    }

    public void Borrow()
    {
        if (Borrowed)
            throw new InvalidOperationException("Book is already borrowed.");

        Borrowed = true;
    }

    public void Return()
    {
        if (!Borrowed)
            throw new InvalidOperationException("Book is not borrowed.");

        Borrowed = false;
    }
}
