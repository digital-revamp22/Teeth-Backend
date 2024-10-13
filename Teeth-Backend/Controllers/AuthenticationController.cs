using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Teeth.Application.Interfaces;
using Teeth.Application.Services.Commands.UserCommandHandlers;
using Teeth.Domain.Models;

namespace Teeth_Backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController(IAppDbContext context) : ControllerBase
{
    [AllowAnonymous]
    [HttpPost("client-signup")]
    public async Task<IActionResult> ClientSignUp([FromBody] RegisterUserCommand userCommand)
    {
        var createUserCommandHandler = new RegisterUserCommandHandler(context);
        var result = await createUserCommandHandler.Handle(userCommand, new CancellationToken());
        return Created();
    }

    [AllowAnonymous]
    [HttpPost("user-login")]
    public async Task<IActionResult> Login([FromBody] UserLogin login)
    {
        return Ok();
    }


    // GET: api/<ValuesController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<ValuesController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ValuesController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ValuesController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ValuesController>/5
    public void Delete(int id)
    {
    }
}
