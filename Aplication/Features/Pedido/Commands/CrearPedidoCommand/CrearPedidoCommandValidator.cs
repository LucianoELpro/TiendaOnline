using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Features.Pedido.Commands
{
    public class CrearPedidoCommandValidator : AbstractValidator<CrearPedidoCommand>
    {
        public CrearPedidoCommandValidator()
        {
            RuleFor(c => c.IdArqueo)
                .NotEmpty().WithMessage("¨{PropertyName} No puede ser Nulo");
            RuleFor(c => c.IdCliente)
                .NotEmpty().WithMessage("¨{PropertyName} No puede ser Nulo");
            RuleFor(c => c.IdMasterTipoPedido)
                .NotEmpty().WithMessage("¨{PropertyName} No puede ser Nulo");
            RuleFor(c => c.IdUser)
                .NotEmpty().WithMessage("¨{PropertyName} No puede ser Nulo");
            RuleFor(c => c.Direccion)
                .NotEmpty().WithMessage("¨{PropertyName} No puede ser Nulo");
            RuleFor(c => c.Telefono)
                .NotEmpty().WithMessage("¨{PropertyName} No puede ser Nulo");

        }   
    }
}
