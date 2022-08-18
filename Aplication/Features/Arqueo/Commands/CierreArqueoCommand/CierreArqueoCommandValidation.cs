using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Features.Arqueo.Commands.CierreArqueoCommand
{
    public class CierreArqueoCommandValidation : AbstractValidator<CierreArqueoCommand>
    {
        public CierreArqueoCommandValidation()
        {
            RuleFor(c => c.IdArqueo)
                .NotEmpty().WithMessage("{PropertyName} No puede ser nulo");
            RuleFor(c => c.Real)
                .NotEmpty().WithMessage("{PropertyName} No puede ser nulo");
            RuleFor(c=>c.IdUsuario)
                .NotEmpty().WithMessage("{PropertyName} No puede ser nulo");

        }
    }
}
