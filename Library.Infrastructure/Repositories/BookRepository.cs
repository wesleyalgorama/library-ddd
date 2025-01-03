using Library.Domain.Entities;
using Library.Domain.Interfaces;

namespace Library.Infrastructure.Repositories;

public class BookRepository : IBookRepository
{
    private readonly List<Book> _books;

    public BookRepository()
    {
        if (this._books == null) _books = new List<Book>();
    }

    public IEnumerable<Book> GetAll()
    {
        return _books;
    }

    public Book Get(long id)
    {
        return _books.FirstOrDefault(book => book.Id == id);
    }

    public void Add(Book book)
    {
        if (_books.Any(b => b.Id == book.Id))
        {
            throw new ArgumentException("Book with the same ID already exists.");
        }

        _books.Add(book);
    }
}
