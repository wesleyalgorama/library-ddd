namespace Library.Application.Services;

using Library.Domain.Entities;
using Library.Domain.Interfaces;

public class LibraryService
{
    private readonly IBookRepository _bookRepository;

    public LibraryService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public IEnumerable<Book> GetAll()
    {
        return _bookRepository.GetAll();
    }

    public Book Get(long id)
    {
        var book = _bookRepository.Get(id);

        if (book == null) throw new ArgumentException("Book not found.");

        return book;
    }

    public void Add(Book book)
    {
        _bookRepository.Add(book);
    }

    public void Borrow(long id)
    {
        var book = Get(id);

        book.Borrow();
    }

    public void Return(long id)
    {
        var book = Get(id);

        book.Return();
    }
}
