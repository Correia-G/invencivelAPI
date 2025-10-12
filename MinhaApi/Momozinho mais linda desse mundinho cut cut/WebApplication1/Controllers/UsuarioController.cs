using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuariosRepository services;

        public UsuarioController(UsuariosRepository services)
        {
            this.services = services;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] UsuarioRequest loginRequest)
        {

            if (string.IsNullOrEmpty(loginRequest.Email) || string.IsNullOrEmpty(loginRequest.Password))
            {
                return BadRequest("Campos Obrigatórios");
            }

            var usuarioLogin = await services.LoginUsuario(loginRequest.Email, loginRequest.Password);

            if (usuarioLogin != null)
            {
                return Ok("Usuario encontrado");
            }
            else
            {
                return BadRequest("Usuario não cadastrado");
            }

        }


    }
}
