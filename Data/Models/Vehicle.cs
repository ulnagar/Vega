using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vega.Data.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public Make Make { get; set; }
        public int MakeId { get; set; }
        public Model Model { get; set; }
        public int ModelId { get; set; }
        public bool IsRegistered { get; set; }
        public ICollection<VehicleFeature> VehicleFeatures { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
    }
}
