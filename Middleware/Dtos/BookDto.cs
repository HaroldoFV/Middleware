namespace Middleware.DTOS;

public class BookDto
{
    public Dictionary<string, string> Abbrev { get; set; }
    public string Author { get; set; }
    public int Chapters { get; set; }
    public string Group { get; set; }
    public string Name { get; set; }
    public string Testament { get; set; }

    public BookDto()
    {
    }

    public void Update(Dictionary<string, string> abbrev, string author, int chapters,
                    string group, string name, string testament)
    {
        Abbrev = abbrev;
        Author = author;
        Chapters = chapters;
        Group = group;
        Name = name;
        Testament = testament;
    }


}