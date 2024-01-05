using System.Text.Json;
using Middleware.DTOS;
using Middleware.Services.Interfaces;
using Middleware.Settings;

namespace Middleware.Services;

public class VersionService(IHttpClientFactory httpClientFactory) : IVersionService
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient("Versions");
    private readonly string url = Configurations.ApiSetting.Uri;

    public async Task<IEnumerable<VersionDto>> GetAllVersionsAsync()
    {
        var response = await _httpClient.GetAsync($"{url}/Versions");

        if (response.IsSuccessStatusCode)
        {
            var versions =
                JsonSerializer.Deserialize<IEnumerable<VersionDto>>(await response.Content.ReadAsStringAsync());
            return versions;
        }

        throw new Exception("error occurred while fetching versions data");
    }
}