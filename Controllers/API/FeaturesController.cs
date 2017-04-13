using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega.Data;
using Vega.Data.DTO;
using Vega.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vega.Controllers.API
{
    [Route("api/features")]
    public class FeaturesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;

        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/values
        [HttpGet("/api/features")]
        public ICollection<FeatureDTO> Get()
        {
            var features = _context.Features.ToList();

            return _mapper.Map<List<Feature>, List<FeatureDTO>>(features);
        }
    }
}
