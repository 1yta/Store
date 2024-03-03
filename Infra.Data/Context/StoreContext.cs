using Barnamenevisan.Localizing.Extensions;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RegisterLocalizing();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StoreContext).Assembly);

        }
    }
}
