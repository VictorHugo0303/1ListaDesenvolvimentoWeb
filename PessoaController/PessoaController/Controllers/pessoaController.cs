using Microsoft.AspNetCore.Mvc;
using PessoaController.Models;

namespace PessoaController.Controllers
{
    [ApiController]
    [Route ("API/Pessoa")]
    public class pessoaController : ControllerBase
    {
        [HttpPost] 
        public IActionResult CalcIMC([FromBody] pessoaDados request) 
        {
            return Ok(request.Imc());     
        }
    }
}
