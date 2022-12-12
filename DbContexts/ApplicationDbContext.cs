using GetEntityDetailsApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace GetEntityDetailsApi.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<EntityDetails> EntityDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EntityDetails>().HasData(new EntityDetails
            {
                ACN = 111111,
                EntityName = "AAA Enterprise",
                Address ="1st street, AU",
                personalEmailID="aaa@test.com"
            });
        }
    }
}