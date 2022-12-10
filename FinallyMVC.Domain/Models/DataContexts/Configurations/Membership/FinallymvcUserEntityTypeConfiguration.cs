using FinallyMVC.Domain.Models.Entities.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Models.DataContexts.Configurations.Membership
{
    public class FinallymvcUserEntityTypeConfiguration : IEntityTypeConfiguration<FinallymvcUser>
    {
        public void Configure(EntityTypeBuilder<FinallymvcUser> builder)
        {
            builder.ToTable("Users", "Membership");
        }

    }
}
