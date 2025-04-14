using AutoMapper;
using FribergHome_API.Data.Repositories;
using FribergHome_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using FribergHome_Shared.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FribergHome_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PropertiesController : ControllerBase
	{
		private readonly IPropertyRepository _propertyRepo;
		private readonly IMapper _mapper;

		public PropertiesController(IPropertyRepository propertyRepo, IMapper mapper)
		{
			 _propertyRepo = propertyRepo;
			_mapper = mapper;
		}

		// GET: api/<PropertiesController>
		[HttpGet]
		public async Task<ActionResult> Get()
		{
			var properties =  await _propertyRepo.GetAllAsync() ?? [];
			if (properties == null) 
			{ 
				return NotFound();
			}
			return Ok(properties);
		}

		// GET api/<PropertiesController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult> Get(int id)
		{
			var property = await _propertyRepo.GetAsync(id);

			var DTO = _mapper.Map<PropertyDTO>(property);

			if (DTO == null)
			{
				return NotFound();
			}
			return Ok(DTO);
		}

		// POST api/<PropertiesController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<PropertiesController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<PropertiesController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
