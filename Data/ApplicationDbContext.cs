
using System;
using Code1stlab.Data;
using Code1stlab.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Code1stlab.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }   

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<City>().HasData(SampleData.GetCities());
            modelBuilder.Entity<Province>().HasData(SampleData.GetProvinces());
        }
    }
}
