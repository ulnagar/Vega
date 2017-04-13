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
    [Route("api/makes")]
    public class MakesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;

        public MakesController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/values
        [HttpGet("/api/makes")]
        public ICollection<MakeDTO> Get()
        {
            var makes = _context.Makes.Include(make => make.Models).ToList();

            return _mapper.Map<List<Make>, List<MakeDTO>>(makes);
        }
    }
}
