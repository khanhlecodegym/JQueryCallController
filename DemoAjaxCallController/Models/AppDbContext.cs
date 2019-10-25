using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAjaxCallController.Models
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _config;

        public AppDbContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }
        public DbSet<Codegymer> Codegymers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DemoAjax"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Codegymer>().HasData(
                new { Id = 1, Name = "Le Van Bon", IsDepTrai = false, IsGiau = false, IsThongMinh = false } ,
                new { Id = 2, Name = "Nguyen Van Quy", IsDepTrai = false, IsGiau = false, IsThongMinh = false },
                new { Id = 3, Name = "Bui Hoang Long", IsDepTrai = false, IsGiau = false, IsThongMinh = false },
                new { Id = 4, Name = "Phan Van My", IsDepTrai = false, IsGiau = false, IsThongMinh = false }
                );
        }
    }
}
