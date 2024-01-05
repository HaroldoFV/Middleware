using Microsoft.AspNetCore.Mvc;
using Middleware.DTOS;
using Middleware.Services;
using Middleware.Services.Interfaces;

namespace Middleware.Controllers;


[Route("api/verses")]
[ApiController]
public class VersesController(IVerseService verseService) : ControllerBase
{
    [HttpGet("{version}/{abbrev}/{chapter}/")]
    public async Task<ActionResult<BookDto>> Get(string version, string abbrev, int chapter)
    {
        return Ok(await verseService.GetGyVersionAndAbbrevAndChapter(version, abbrev, chapter));
    }

    [HttpGet("{version}/{abbrev}")]
    public async Task<ActionResult<BookDto>> GetRandomVerseBook(string version, string abbrev)
    {
        return Ok(await verseService.GetRandomVerseBook(version, abbrev));
    }
}