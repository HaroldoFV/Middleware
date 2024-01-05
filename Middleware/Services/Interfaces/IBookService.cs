using Middleware.DTOS;

namespace Middleware.Services.Interfaces;

public interface IBookService
{
    Task<IEnumerable<BookDto>> GetAllBooksAsync();
    Task<BookDto> GetBookByAbbrevAsync(string abbrev);
}