using Middleware.DTOS;

namespace Middleware.Services.Interfaces;

public interface IVerseService
{
    Task<VerseDto> GetGyVersionAndAbbrevAndChapter(string version, string abbrev, int chapter);
    Task<VerseDtRandom> GetRandomVerseBook(string version, string abbrev);


}