using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Value> Values { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>().HasData(
                new Value {
                    Id = 1,
                    Name = "Value-first"
                },
                new Value {
                    Id = 2,
                    Name = "Value-second"
                },
                new Value {
                    Id = 3,
                    Name = "Value-third"
                }
            );
        }
    }
}
