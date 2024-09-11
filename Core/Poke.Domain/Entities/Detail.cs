using Poke.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Domain.Entities
{
    public class Detail : EntityBase
    {
        public Detail()
        {
            
        }

        public Detail(string type, string description, int categoryId, decimal height, decimal weight)
        {
            Type = type;
            Description = description;
            CategoryId = categoryId;
            Height = height;
            Weight = weight;
        }

        public decimal Height { get; set; }

        public decimal Weight { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}
