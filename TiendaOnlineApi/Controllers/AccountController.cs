using Aplication.DTOs.Account;
using Aplications.Feautres.Users.Commands.AutheticationUser;
using Aplications.Feautres.Users.Commands.RegisterUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TiendaOnlineApi.Controllers;

namespace TiendaOnlineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseApiController
    {        
        [HttpPost("autenticate")]
        public async Task<IActionResult> AuthenticateAsync(AuthenticationRequest request)
        {
            return Ok(await Mediator.Send(new AuthenticateUserCommand
            {
                Email=request.Email,
                Password=request.Password,
                IpAddress= GenerateIpAddress()

            }));
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegisterRequest request)
        {
            return Ok(await Mediator.Send(new RegisterUserCommand
            {
                FistName=request.FistName,
                LastName=request.LastName,
                Email = request.Email,
                Password = request.Password,
                ConfirmPassword=request.ConfirmPassword,
                UserName=request.UserName,
                Origin=Request.Headers["origin"]
                
            } ));
        }

        private string GenerateIpAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                return Request.Headers["X-Forwarded-For"];
            }
            else
            {
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            }

        }
    }
}
