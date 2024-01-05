using System.Text.Json;
using Middleware.DTOS;
using Middleware.Services.Interfaces;
using Middleware.Settings;

namespace Middleware.Services;

public class BookService(IHttpClientFactory httpClientFactory) : IBookService
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient("books");
    private readonly string url = Configurations.ApiSetting.Uri;

    public async Task<IEnumerable<BookDto>> GetAllBooksAsync()
    {
        var response = await _httpClient.GetAsync($"{url}/books");

        if (response.IsSuccessStatusCode)
        {
            var books = JsonSerializer.Deserialize<IEnumerable<BookDto>>(await response.Content.ReadAsStringAsync());
            return books;
        }

        throw new Exception("error occurred while fetching books data");
    }

    public async Task<BookDto> GetBookByAbbrevAsync(string abbrev)
    {
        var response = await _httpClient.GetAsync($"{url}/books/{abbrev}");

        if (response.IsSuccessStatusCode)
        {
            var book = JsonSerializer.Deserialize<BookDto>(await response.Content.ReadAsStringAsync());
            return book;
        }

        throw new Exception($"Error occurred while fetching book data for abbreviation: {abbrev}.");
    }
}