using System.Text.Json;
using Middleware.DTOS;
using Middleware.Services.Interfaces;
using Middleware.Settings;

namespace Middleware.Services;

public class VerseService(IHttpClientFactory httpClientFactory) : IVerseService
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient("verses");
    private readonly string url = Configurations.ApiSetting.Uri;

    public async Task<VerseDto> GetGyVersionAndAbbrevAndChapter(string version, string abbrev, int chapter)
    {
        var response = await _httpClient.GetAsync($"{url}/verses/{version}/{abbrev}/{chapter}");

        if (response.IsSuccessStatusCode)
        {
            var verse = JsonSerializer.Deserialize<VerseDto>(await response.Content.ReadAsStringAsync());
            return verse;
        }

        throw new Exception($"Error occurred while fetching verse data.");
    }

    public async Task<VerseDtRandom> GetRandomVerseBook(string version, string abbrev)
    {
        var response = await _httpClient.GetAsync($"{url}/verses/{version}/{abbrev}/random");

        if (response.IsSuccessStatusCode)
        {
            var verse = JsonSerializer.Deserialize<VerseDtRandom>(await response.Content.ReadAsStringAsync());
            return verse;
        }

        throw new Exception($"Error occurred while fetching verse data.");
    }
}