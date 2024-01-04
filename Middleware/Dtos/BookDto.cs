namespace Middleware.DTOS;

public class BookDto
{
    public Dictionary<string, string> Abbrev { get; set; }
    public string Author { get; set; }
    public int Chapters { get; set; }
    public string Group { get; set; }
    public string Name { get; set; }
    public string Testament { get; set; }
}