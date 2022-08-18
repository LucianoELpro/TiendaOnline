using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Exceptions
{
    public class AccountException : Exception
    {
        //public List<string> Errors { get; set; }
        public AccountException() : base() { }
        public AccountException(string message) : base(message) { }

        //public AccountException(IEnumerable<IdentityError> faulires) : this()
        //{
        //    foreach (var failure in faulires)
        //    {
        //        Errors.Add(failure.Description);
        //    }

        //}
        public AccountException(string message, params object[] args) : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {

        }
    }
}