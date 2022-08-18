using Aplication.DTOs.Account;
using Aplication.Interfaces.Account;
using Aplication.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplications.Feautres.Users.Commands.AutheticationUser
{
    public class AuthenticateUserCommand : IRequest<Response<AuthenticationDto>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string IpAddress { get; set; }

    }
    public class AuthenticateCommandHandler : IRequestHandler<AuthenticateUserCommand, Response<AuthenticationDto>>
    {
        private readonly IAccountService _accountService;
        public AuthenticateCommandHandler(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public async Task<Response<AuthenticationDto>> Handle(AuthenticateUserCommand request, CancellationToken cancellationToken)
        {
            return await _accountService.AuthenticateAsync(new AuthenticationRequest
            {

                Email = request.Email,
                Password = request.Password,

            }, request.IpAddress);
        }
    }
}
