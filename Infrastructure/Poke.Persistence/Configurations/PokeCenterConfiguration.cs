using Bogus;
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
    public class PokeCenterConfiguration : IEntityTypeConfiguration<PokeCenter>
    {
        public void Configure(EntityTypeBuilder<PokeCenter> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);

            Faker faker = new("tr");

            PokeCenter pokeCenter1 = new()
            {
                Id = 1,
                Name = faker.Commerce.Department(),
                CreatedTime = DateTime.Now,
                IsDeleted = false
            };

            PokeCenter pokeCenter2 = new()
            {
                Id = 2,
                Name = faker.Commerce.Department(),
                CreatedTime = DateTime.Now,
                IsDeleted = false
            };

            PokeCenter pokeCenter3 = new()
            {
                Id = 3,
                Name = faker.Commerce.Department(),
                CreatedTime = DateTime.Now,
                IsDeleted = false
            };
            builder.HasData(pokeCenter1, pokeCenter2, pokeCenter3);
        }
    }
}
