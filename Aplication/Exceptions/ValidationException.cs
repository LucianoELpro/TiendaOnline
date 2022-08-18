using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Exceptions
{
    public class ValidationException : Exception
    {
        public List<string> Errors { get; set; }

        public ValidationException() : base("Se producieron uno o más errores")
        {
            Errors = new List<string>();
        }
        public ValidationException(IEnumerable<ValidationFailure> faulires):this()
        {
            foreach (var failure in faulires)
            {
                Errors.Add(failure.ErrorMessage);
            }
            
        }
    }
}
