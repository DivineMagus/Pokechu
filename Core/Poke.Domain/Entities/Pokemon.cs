using Poke.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Domain.Entities
{
    public class Pokemon : EntityBase
    {

        public Pokemon()
        {

        }

        public Pokemon(string title, string description, int pokeCenterId, decimal price, decimal discount)
        {
            Title = title;
            Description = description;
            PokeCenterId = pokeCenterId;
            Price = price;
            Discount = discount;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PokeCenterId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }

        public PokeCenter PokeCenter { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
        //public required string ImagePath { get; set; }
    }
}