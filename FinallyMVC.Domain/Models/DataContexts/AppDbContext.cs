using FinallyMVC.Domain.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Models.DataContexts
{
    public class AppDbContext :IdentityDbContext<IdentityUser<int>,IdentityRole<int>,int>/*DbContext*/
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Service> Serviceses { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<SocialNetworking> SocialNetworkings { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }

}
