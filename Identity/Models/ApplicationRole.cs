﻿
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Identity.Models
{
    public class ApplicationRole :IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
