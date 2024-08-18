using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class freteController : ControllerBase
    {
        [HttpPost]

        public IActionResult verDados([FromBody] Dados request)
        {
            return Ok(request.frete());
        }
    }
}
