using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Data;
using NZWalks.API.DTOs;
using NZWalks.API.Models;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;

        public RegionsController(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET ALL
        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions = dbContext.Regions.ToList();

            var dto = regions.Select(region => new RegionDto
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name,
                RegionImageUrl = region.RegionImageUrl
            }).ToList();

            return Ok(dto);
        }

        // GET BY ID
        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var region = dbContext.Regions.FirstOrDefault(x => x.Id == id);

            if (region == null)
                return NotFound();

            var dto = new RegionDto
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name,
                RegionImageUrl = region.RegionImageUrl
            };

            return Ok(dto);
        }

        // POST (CREATE)
        [HttpPost]
        public IActionResult CreateRegion([FromBody] AddRegionRequestDto request)
        {
            var region = new Regions
            {
                Id = Guid.NewGuid(),
                Code = request.Code,
                Name = request.Name,
                RegionImageUrl = request.RegionImageUrl
            };

            dbContext.Regions.Add(region);
            dbContext.SaveChanges();

            var dto = new RegionDto
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name,
                RegionImageUrl = region.RegionImageUrl
            };

            return CreatedAtAction(nameof(GetById), new { id = region.Id }, dto);
        }

        // PUT (UPDATE)
        [HttpPut("{id:guid}")]
        public IActionResult UpdateRegion(
            Guid id,
            [FromBody] UpdateRegionRequestDto request)
        {
            var region = dbContext.Regions.FirstOrDefault(x => x.Id == id);

            if (region == null)
                return NotFound();

            region.Code = request.Code;
            region.Name = request.Name;
            region.RegionImageUrl = request.RegionImageUrl;

            dbContext.SaveChanges();

            var dto = new RegionDto
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name,
                RegionImageUrl = region.RegionImageUrl
            };

            return Ok(dto);
        }
    }
}