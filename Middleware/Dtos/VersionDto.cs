using System.Text.Json.Serialization;

namespace Middleware.DTOS;

public class VersionDto
{
    [JsonPropertyName("version")] public string Version { get; set; }

    [JsonPropertyName("verses")] public int Verses { get; set; }
}