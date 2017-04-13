using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Vega.Data.DTO;
using Vega.Data.Models;

namespace Vega.Extensions.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeDTO>().ReverseMap();
            CreateMap<Model, ModelDTO>().ReverseMap();
            CreateMap<Feature, FeatureDTO>().ReverseMap();

            CreateMap<Vehicle, VehicleDTO>().ReverseMap();
            CreateMap<VehicleFeature, VehicleFeatureDTO>().ReverseMap();
        }

    }
}
