using Middleware.DTOS;

namespace Middleware.Services.Interfaces;

public interface IVersionService
{
    Task<IEnumerable<VersionDto>> GetAllVersionsAsync();
}