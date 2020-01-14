using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFGetStarted
{
    public class TestDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 数据库连接
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=weijTest;Integrated Security=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
        public DbSet<Role> Roles { get; set; }
    }
}
