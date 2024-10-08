﻿using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StatusController : ControllerBase
{
    private const int version = 31;

    [HttpGet]
    public async Task<IActionResult> HealthCheck()
    {
        var init = DateTime.UtcNow;
        await Task.Delay(TimeSpan.FromSeconds(1));
        var fim = DateTime.UtcNow;

        return Ok($"{version} - {init:HH:mm:ss} - {fim:HH:mm:ss}");
    }
}
