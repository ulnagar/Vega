using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega.Data;
using Vega.Data.DTO;
using Vega.Data.Models;

namespace Vega.Controllers.API
{
    //[Route("api/vehicle")]
    public class VehicleController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;

        public VehicleController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/values
        [HttpGet("/api/vehicle")]
        public IActionResult GetAll()
        {
            var vehicles = _context.Vehicles.Include(v => v.VehicleFeatures).ToList();

            return Ok(_mapper.Map<List<Vehicle>, List<VehicleDTO>>(vehicles));
        }

        [HttpGet("/api/vehicle/{id}")]
        public IActionResult GetOne(int id)
        {
            var vehicle = _context.Vehicles.Include(v => v.VehicleFeatures).SingleOrDefault(v => v.Id == id);

            if (vehicle == null)
                return NotFound();

            return Ok(_mapper.Map<Vehicle, VehicleDTO>(vehicle));
        }

        [HttpPost("/api/vehicle")]
        public IActionResult Create([FromBody] VehicleDTO vehicleDTO)
        {
            var vehicle = _mapper.Map<VehicleDTO, Vehicle>(vehicleDTO);

            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut("/api/vehicle/{id}")]
        public IActionResult Update(int id, [FromBody] VehicleDTO vehicleDTO)
        {
            var vehicle = _context.Vehicles.Include(v => v.VehicleFeatures).SingleOrDefault(v => v.Id == id);

            if (vehicle == null)
                return NotFound();

            if (vehicle.MakeId != vehicleDTO.MakeId)
                vehicle.MakeId = vehicleDTO.MakeId;

            if (vehicle.ModelId != vehicleDTO.ModelId)
                vehicle.ModelId = vehicleDTO.ModelId;

            if (vehicle.IsRegistered != vehicleDTO.IsRegistered)
                vehicle.IsRegistered = vehicleDTO.IsRegistered;

            if (vehicle.ContactName != vehicleDTO.ContactName)
                vehicle.ContactName = vehicleDTO.ContactName;

            if (vehicle.ContactPhone != vehicleDTO.ContactPhone)
                vehicle.ContactPhone = vehicleDTO.ContactPhone;

            if (vehicle.ContactEmail != vehicleDTO.ContactEmail)
                vehicle.ContactEmail = vehicleDTO.ContactEmail;

            var features = new List<VehicleFeature>();

            foreach (var feature in vehicleDTO.VehicleFeatures)
            {
                if (vehicle.VehicleFeatures.Any(vf => vf.VehicleId == feature.VehicleId && vf.FeatureId == feature.FeatureId))
                {
                    // Do Nothing, this still exists
                }
                else
                {
                    features.Add(_mapper.Map<VehicleFeatureDTO, VehicleFeature>(feature));
                }
            }

            foreach (var feature in vehicle.VehicleFeatures)
            {
                if (vehicleDTO.VehicleFeatures.Any(vf => vf.VehicleId == feature.VehicleId && vf.FeatureId == feature.FeatureId))
                {
                    features.Add(feature);
                }
                else
                {
                    // Do Nothing, this no longer exists!
                }
            }

            vehicle.VehicleFeatures = features;

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("/api/vehicle/{id}")]
        public IActionResult Delete(int id)
        {
            var vehicle = _context.Vehicles.SingleOrDefault(v => v.Id == id);

            if (vehicle == null)
            {
                return NotFound();
            }
            else
            {
                _context.Vehicles.Remove(vehicle);
                _context.SaveChanges();

                return Ok();
            }
        }
    }
}