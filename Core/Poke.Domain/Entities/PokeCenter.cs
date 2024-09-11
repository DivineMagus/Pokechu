using Poke.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Domain.Entities
{
    public class PokeCenter : EntityBase
    {
        public PokeCenter()
        {
        }
        public PokeCenter(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}