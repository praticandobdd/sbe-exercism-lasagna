using Microsoft.AspNetCore.Mvc;

namespace Cop.Sbe.Exercism.Lasagna.WebApi.Controllers;

/// <summary>
/// Lasagna challenge from Exercism.com
/// </summary>
[ApiController]
[Route("/api/lasagna")]
public class LasagnaController : ControllerBase
{

    private readonly ILogger<LasagnaController> _logger;

/// <summary>
/// Inject logger
/// </summary>
/// <param name="logger"></param>
    public LasagnaController(ILogger<LasagnaController> logger)
    {
        _logger = logger;
    }

/// <summary>
/// Get42
/// </summary>
/// <returns></returns>
    [HttpGet("x")]
    public async Task<ActionResult<string>> Get42() => Ok(await Task.FromResult("42"));

/// <summary>
/// /minutes/expected
/// </summary>
/// <returns></returns>
    [HttpGet("minutes/expected")]
    public async Task<ActionResult<string>> ExpectedMinutesInOven() => Ok(await Task.FromResult(new Lasagna().ExpectedMinutesInOven()));

/// <summary>
/// /minutes/remaining
/// </summary>
/// <returns></returns>
    [HttpGet("minutes/remaining")]
    public async Task<ActionResult<string>> RemainingMinutesInOven(int actualMinutes) => Ok(await Task.FromResult(new Lasagna().RemainingMinutesInOven(actualMinutes)));    


/// <summary>
/// /minutes/preparation
/// </summary>
/// <returns></returns>
    [HttpGet("minutes/preparation")]
    public async Task<ActionResult<string>> PreparationTimeInMinutes(int addedLayers) => Ok(await Task.FromResult(new Lasagna().PreparationTimeInMinutes(addedLayers)));    

/// <summary>
/// /minutes/elapsed
/// </summary>
/// <returns></returns>
    [HttpGet("minutes/elapsed")]
    public async Task<ActionResult<string>> PreparationTimeInMinutes(int addedLayers, int minutesInOven) => Ok(await Task.FromResult(new Lasagna().ElapsedTimeInMinutes(addedLayers,minutesInOven)));    

}
