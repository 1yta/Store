using Barnamenevisan.Localizing.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RegisterLocalizing();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StoreContext).Assembly);

        }
    }
}
