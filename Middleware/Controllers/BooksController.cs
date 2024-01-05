using Microsoft.AspNetCore.Mvc;
using Middleware.DTOS;
using Middleware.Services;
using Middleware.Services.Interfaces;

namespace Middleware.Controllers;

[Route("api/books")]
[ApiController]
public class BooksController(IBookService bookService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookDto>>> Get()
    {
        return Ok(await bookService.GetAllBooksAsync());
    }

    [HttpGet("{abbrev}")]
    public async Task<ActionResult<BookDto>> GetGyAbbrev(string abbrev)
    {
        return Ok(await bookService.GetBookByAbbrevAsync(abbrev));
    }
}