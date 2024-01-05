using System.Text.Json.Serialization;

namespace Middleware.DTOS;

public class VerseDto
{
    [JsonPropertyName("book")] public Book Book { get; set; }

    [JsonPropertyName("chapter")] public Chapter Chapter { get; set; }

    [JsonPropertyName("verses")] public Verse[] Verses { get; set; }
}

public class VerseDtRandom
{
    [JsonPropertyName("book")] public Book Book { get; set; }

    [JsonPropertyName("chapter")] public int Chapter { get; set; }

    [JsonPropertyName("text")] public string Text { get; set; }
}

public class Book
{
    [JsonPropertyName("abbrev")] public Abbrev Abbrev { get; set; }

    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("author")] public string Author { get; set; }

    [JsonPropertyName("group")] public string Group { get; set; }

    [JsonPropertyName("version")] public string Version { get; set; }
}

public class Abbrev
{
    [JsonPropertyName("pt")] public string Pt { get; set; }

    [JsonPropertyName("en")] public string En { get; set; }
}

public class Chapter
{
    [JsonPropertyName("number")] public int Number { get; set; }
    [JsonPropertyName("verses")] public int Verses { get; set; }
}

public class Verse
{
    [JsonPropertyName("number")] public int Number { get; set; }

    [JsonPropertyName("text")] public string Text { get; set; }
}