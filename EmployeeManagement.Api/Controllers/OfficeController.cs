using EmployeeManagement.Api.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OfficeController : Controller
	{
		private readonly IOfficeRepository _officeRepository;

		public OfficeController(IOfficeRepository officeRepository)
		{
			_officeRepository = officeRepository;
		}


		// GET: api/<controller>
		[HttpGet]
		public IActionResult GetOffices()
		{
			return Ok(_officeRepository.GetAllOffices());
		}

		// GET api/<controller>/5
		[HttpGet("{id}")]
		public IActionResult GetOfficeById(int id)
		{
			return Ok(_officeRepository.GetOfficeById(id));
		}
	}
}
