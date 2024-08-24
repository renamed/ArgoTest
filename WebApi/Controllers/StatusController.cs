using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StatusController : ControllerBase
{
    [HttpGet]
    public IActionResult HealthCheck()
    {
        return Ok("16");
    }

    // [HttpGet("opa")]
    // public IActionResult Opa()
    // {
    //     return Ok("Opa");
    // }
}
