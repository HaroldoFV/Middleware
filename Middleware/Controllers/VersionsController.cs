using Microsoft.AspNetCore.Mvc;
using Middleware.DTOS;
using Middleware.Services;
using Middleware.Services.Interfaces;

namespace Middleware.Controllers;

[Route("api/versions")]
[ApiController]
public class VersionsController(IVersionService versionService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<VersionDto>>> Get()
    {
        return Ok(await versionService.GetAllVersionsAsync());
    }
}