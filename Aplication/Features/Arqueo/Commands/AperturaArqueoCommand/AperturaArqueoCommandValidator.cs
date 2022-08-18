using FluentValidation;

namespace Aplication.Features.Arqueo.Commands.AperturaArqueoCommand
{
    public class AperturaArqueoCommandValidator : AbstractValidator<AperturaArqueoCommand>
    {
        public AperturaArqueoCommandValidator()
        {
            RuleFor(c => c.IdUsuario)
                .NotEmpty().WithMessage("{PropertyName} no puede ser nulo");
            RuleFor(c => c.IdMasterCaja)
                .NotEmpty().WithMessage("{PropertyName} no puede ser nulo")
                .MaximumLength(5).WithMessage("{PropertyName} no puede exceder de {MaxLength} caracteres");

        }
    }
}
