using FestivalApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FestivalApi.Controllers;

[ApiController]
[Route("/api/festival/[controller]")]
public class LineupController : ControllerBase
{

    private readonly ILineupService _lineupService;
    public LineupController(ILineupService lineupService)
    {
        _lineupService = lineupService;
    }

    [HttpGet(Name = "GetLineup")]
    public IActionResult Get()
    {
        return Ok(_lineupService.GetLineup());
    }
}