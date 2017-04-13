using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Vega.Data.DTO
{
    public class VehicleDTO
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public bool IsRegistered { get; set; }
        public ICollection<VehicleFeatureDTO> VehicleFeatures { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
    }
}