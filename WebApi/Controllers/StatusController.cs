using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StatusController : ControllerBase
{
    private const int version = 28;

    [HttpGet]
    public async Task<IActionResult> HealthCheck()
    {
        var init = DateTime.UtcNow;
        await Task.Delay(TimeSpan.FromSeconds(61));
        var fim = DateTime.UtcNow;

        return Ok($"{version} - {init:HH:mm:ss} - {fim:HH:mm:ss}");
    }
}
