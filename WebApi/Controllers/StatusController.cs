using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StatusController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> HealthCheck()
    {
        var init = DateTime.UtcNow;
        await Task.Delay(TimeSpan.FromSeconds(30));
        var fim = DateTime.UtcNow;
        
        return Ok($"21 - {init:HH:mm:ss} - {fim:HH:mm:ss}");
    }

    [HttpGet("opa")]
    public IActionResult Opa()
    {
        return Ok("Opa");
    }
}
