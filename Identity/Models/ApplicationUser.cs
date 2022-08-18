﻿
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
