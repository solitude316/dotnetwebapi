namespace DotnetWebApi.Web.Controllers;

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Data;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    IDbConnection _conn;
    public HomeController(IDbConnection conn)
    {
        _conn = conn;
    }

    [HttpGet("hello")]
    public async Task<ActionResult<string>> hello()
    {
        _conn.Open();
        var hash_code = _conn.GetHashCode();

        return Ok($"Hello!!!{hash_code}");
    }
}