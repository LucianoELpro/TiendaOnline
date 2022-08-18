
using Identity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Config
{
    public class ApplicationRoleConfig : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(new ApplicationRole
            {
                Id = Guid.NewGuid().ToString().ToLower(),
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
            builder.HasMany(e => e.UserRoles).WithOne(e => e.Role).HasForeignKey(e=>e.RoleId).IsRequired();
        }
    }
}
