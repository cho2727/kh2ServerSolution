using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static kh2ServerApi.Features.Database.Helloworld;

namespace kh2ServerApi.Features.Database;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class DatabaseController : ControllerBase
{
    private readonly IMediator _mediator;

    public DatabaseController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [AllowAnonymous]
    [HttpGet("GetHello")]
    [ProducesResponseType(typeof(Helloworld.Response), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetHello()
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var request = new Helloworld.Command();        //await Task.Delay(TimeSpan.FromSeconds(5));
        var response = await _mediator.Send(request);

        return Ok(response);
    }


    [AllowAnonymous]
    [HttpGet("Stations")]
    [ProducesResponseType(typeof(StationInfo.Response), StatusCodes.Status200OK)]
    //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> StationInfo()
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var request = new StationInfo.Command();
        var response = await _mediator.Send(request);
        return Ok(response);
    }
}
