using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vega.Data.DTO
{
    public class MakeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelDTO> Models { get; set; }
    }
}
