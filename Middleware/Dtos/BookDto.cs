using System.Text.Json.Serialization;

namespace Middleware.DTOS;

public class BookDto
{
    [JsonPropertyName("abbrev")] public Dictionary<string, string> Abbrev { get; set; }

    [JsonPropertyName("author")] public string Author { get; set; }

    [JsonPropertyName("chapters")] public int Chapters { get; set; }

    [JsonPropertyName("group")] public string Group { get; set; }

    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("testament")] public string Testament { get; set; }
    
    [JsonPropertyName("comment")] public string Comment { get; set; }
}