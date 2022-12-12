using System;
using WpfApp3.Models;
using Microsoft.EntityFrameworkCore;

namespace WpfApp3.Context
{
    class ApplicationContext : DbContext
    {
        public DbSet<Human> Humans { get; set; }

        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HOMEPC\\MSSQLSERVER01;Database=Chat;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
