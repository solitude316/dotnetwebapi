namespace dotnetwebapi.Web.Controllers;

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    public HomeController()
    {
        
    }

    [HttpGet("hello")]
    public async Task<ActionResult<string>> hello()
    {
        return Ok("Hello!!!");
    }
}