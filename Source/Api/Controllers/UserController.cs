namespace Api.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Api.Entities;
using Api.Repositories;
using Api.Dto;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRepo _userRepo;

    public UserController(IUserRepo userRepo)
    {
        _userRepo = userRepo;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] CreateUserPayload payload)
    {
        try
        {
            var result = await _userRepo.AddAsync(new Entities.User(){
                email = payload.email,
                password = Api.Helpers.StringHelper.GetSha256Hash(payload.password),
                firstname = payload.firstname,
                lastname = payload.lastname,
                birthday = payload.birthday,
                gender = payload.gender
            });

            return Ok(new {
                code = "00001"
            });
        }
        catch (Exception ex)
        {
            return BadRequest(new {
                code = 9999,
                message = ex.Message
            });
        }



    }

    

    [HttpGet("info/{uid}")]
    public async Task<IActionResult> GetAll(string uid)
    {
        try 
        {
            User user = await _userRepo.GetUserByIdAsync(Guid.Parse(uid));

            return Ok(new {
                code = "A0000",
                data = user
            });
        }
        catch(ArgumentNullException)
        {
            return Ok(new {
                code = "00001"
            });
        }
        catch(Exception ex)
        {
            return BadRequest(new {
                code = "99999",
                message = ex.Message
            });
        }    
    }
}