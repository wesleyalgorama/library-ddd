namespace Library.Domain.Interfaces;

using Library.Domain.Entities;

public interface IBookRepository
{
    IEnumerable<Book> GetAll();
    Book Get(long id);
    void Add(Book book);
}
