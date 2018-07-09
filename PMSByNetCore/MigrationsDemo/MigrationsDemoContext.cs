using Microsoft.EntityFrameworkCore;
using System;

namespace MigrationsDemo
{
    public class MigrationsDemoContext:DbContext
    {
        public MigrationsDemoContext(DbContextOptions<MigrationsDemoContext> options)
                : base(options)
        {
        }
        public DbSet<UserInfo> Users { get; set; }
    }
}
