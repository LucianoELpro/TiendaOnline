using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplication.Behaviors
{
    public class ValidationPipelineBehaviors<TRequest,TResponse> : IPipelineBehavior<TRequest,TResponse> 
        where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validator;
        public ValidationPipelineBehaviors(IEnumerable<IValidator<TRequest>> validator)
        {
            _validator = validator;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var context = new FluentValidation.ValidationContext<TRequest>(request);
            var result = await Task
                .WhenAll(_validator
                .Select(v => v
                .ValidateAsync(context, cancellationToken)));
            var failures = result
                .SelectMany(v => v.Errors)
                .Where(f => f != null)
                .ToList();
            if (failures.Count!=0)
            {
                throw new Exceptions.ValidationException(failures);
            }
            else
            {
                return await next();
            }
        }
    }
        
   
}
