using Cov19.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cov19.Data
{
    public class DataContext : IdentityDbContext<IdentityUser> 
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Patients> Patients { get; set; }
        public DbSet<Hospitals> Hospitals { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Country> Country { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
