using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Features.Clientes.Commands.CrearClienteCommand
{
    public class CrearClienteCommandValidation : AbstractValidator<CrearClienteCommand>
    {
        public CrearClienteCommandValidation()
        {
            RuleFor(c => c.IdMasterGenero)
                .NotEmpty().WithMessage("{PropertyName} No puede ser Nulo")
                .MaximumLength(5).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
            RuleFor(c => c.Nombre)
                .NotEmpty().WithMessage("{PropertyName} No puede ser Nulo");
            RuleFor(c => c.IdMasterGenero)
                .NotEmpty().WithMessage("{PropertyName} No puede ser Nulo")
                .MaximumLength(5).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
            RuleFor(c => c.AppePaterno)
                .NotEmpty().WithMessage("{PropertyName} No puede ser Nulo");
            RuleFor(c => c.AppeMaterno)
                .NotEmpty().WithMessage("{PropertyName} No puede ser Nulo");
            RuleFor(c => c.Telefono)
                .NotEmpty().WithMessage("{PropertyName} No puede ser Nulo");
            RuleFor(c => c.Direccion)
                .NotEmpty().WithMessage("{PropertyName} No puede ser Nulo");
            RuleFor(c => c.IdMasterGenero)
                .NotEmpty().WithMessage("{PropertyName} No puede ser Nulo")
                .MaximumLength(5).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("{PropertyName} No puede ser Nulo");
            RuleFor(c => c.FechaNac)
                .NotEmpty().WithMessage("{PropertyName} No puede ser Nulo");

        }
    }
}
