namespace Library.Api.Controllers;

using Library.Application.Services;
using Library.Domain.Entities;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class BookController : Controller
{
    private readonly LibraryService _libraryService;

    public BookController(LibraryService libraryService)
    {
        _libraryService = libraryService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var books = _libraryService.GetAll();
        return Ok(books);
    }

    [HttpGet("{id}")]
    public IActionResult Get(long id)
    {
        var book = _libraryService.Get(id);
        return Ok(book);
    }

    [HttpPost]
    public IActionResult Add([FromBody] Book book)
    {
        _libraryService.Add(book);
        return Ok(book);
    }

    [HttpPost("{id}/borrow")]
    public IActionResult Borrow(long id)
    {
        _libraryService.Borrow(id);
        return NoContent();
    }

    [HttpPost("{id}/return")]
    public IActionResult Return(long id)
    {
        _libraryService.Return(id);
        return NoContent();
    }
}
