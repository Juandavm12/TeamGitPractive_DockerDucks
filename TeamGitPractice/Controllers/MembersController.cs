using Microsoft.AspNetCore.Mvc;

namespace TeamGitPractice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MembersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMembers()
    {
        var members = new[]
        {
            "Juan David Velásquez Murillo",
            "Alejandra Madrid Calderón",
            "Sara Regino Ferraro",
            "José David Vásquez Díaz",
            "Paula Andrea Calderón Quintero"
        };

        return Ok(members);
    }

    [HttpGet("count")]
    public IActionResult GetCount()
    {
        return Ok(new { total = 5 });
    }
}