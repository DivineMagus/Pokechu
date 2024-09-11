using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poke.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Persistence.Configurations
{
    public class PokemonCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => new { x.PokemonId, x.CategoryId});

            builder.HasOne(p=>p.Pokemon).WithMany(pc => pc.ProductCategories).HasForeignKey(p => p.PokemonId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Category).WithMany(pc => pc.ProductCategories).HasForeignKey(c => c.CategoryId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
