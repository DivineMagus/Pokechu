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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new("tr");

            Detail detail1 = new()
            {
                Id = 1,
                Type = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 1,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };

            Detail detail2 = new()
            {
                Id = 2,
                Type = faker.Lorem.Sentence(2),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 3,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };

            Detail detail3 = new()
            {
                Id = 3,
                Type = faker.Lorem.Sentence(3),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 4,
                CreatedTime = DateTime.Now,
                IsDeleted = false,
            };

            builder.HasData(detail1, detail2, detail3);
        }
    }
}
