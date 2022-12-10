using FinallyMVC.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FinallyMVC.Domain.Models.DataContexts.Configurations.Membership
{
    public class FinallyRoleEntityTypeConfiguration : IEntityTypeConfiguration<FinallymvcRole>
    {
        public void Configure(EntityTypeBuilder<FinallymvcRole> builder)
        {
            builder.ToTable("Roles", "Membership");
        }

    }
}


