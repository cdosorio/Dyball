using Dyball.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Dyball.Data
{
    public class A2spaContext : DbContext
    {
        public A2spaContext(DbContextOptions<A2spaContext> options) : base(options)
        {
        }

        public DbSet<TestData> TestData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestData>().ToTable("TestData");
        }
    }
}