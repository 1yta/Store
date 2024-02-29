using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Context.Configurations.Category
{
    public class CategoryConfig : IEntityTypeConfiguration<Domain.Models.Category>
    {
        public void Configure(EntityTypeBuilder<Domain.Models.Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasQueryFilter(c => !c.IsDeleted);

            builder.Property(c => c.Title).HasMaxLength(500);
        }
    }
}
