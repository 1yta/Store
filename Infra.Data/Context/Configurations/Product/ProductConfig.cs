using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Context.Configurations.Product
{
    public class ProductConfig : IEntityTypeConfiguration<Domain.Models.Product>
    {
        public void Configure(EntityTypeBuilder<Domain.Models.Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasQueryFilter(p => !p.IsDeleted);

            builder.Property(p => p.Title).HasMaxLength(500);

            builder.HasOne(p=>p.Category)
                   .WithMany(c=>c.Products)
                   .HasForeignKey(p => p.CategoryId);
        }
    }
}
