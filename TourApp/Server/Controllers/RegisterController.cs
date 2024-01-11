using System.ComponentModel.DataAnnotations;
using TourApp.Server.data;
using TourApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TourApp.Client.Pages;

namespace TourApp.Server.Controllers
{
	[Route("api")]
	[ApiController]
	public class RegisterController : ControllerBase
	{
		private readonly DataContext _context;

		public RegisterController(DataContext context)
		{
			_context = context;
		}

		[HttpGet("Register")]
		public async Task<ActionResult<List<Users>>> GetAllRegister()
		{
			var list = await _context.AppUsers.ToListAsync();

			return Ok(list);
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<List<Users>>> GetRegister(int id)
		{
			var BookingDB = await _context.AppUsers.FindAsync(id);
			if (BookingDB != null)
			{
				return NotFound("This User doesnt exist");
			}
			return Ok(BookingDB);
		}

		[HttpPost("Register")]
		public async Task<ActionResult<List<Users>>> AddmoreRegister(Users rege)
		{
			_context.AppUsers.Add(rege);
			await _context.SaveChangesAsync();

			return await GetAllRegister();
		}

		[HttpPut("Register/{id}")]
		public async Task<ActionResult<List<Users>>> UpdateRegister(int id, Users rege)
		{
			var BookingDB = await _context.AppUsers.FindAsync(id);
			if (BookingDB != null)
			{
				return NotFound("This Hotel does not exist");
			}
			BookingDB.UserID = rege.UserID;
			BookingDB.FullName = rege.FullName;
			BookingDB.PassPort = rege.PassPort;
			BookingDB.Phone = rege.Phone;


			_context.AppUsers.Add(BookingDB);
			await _context.SaveChangesAsync();

			return await GetAllRegister();

		}
		[HttpDelete("{id}")]
		public async Task<ActionResult<List<Users>>> DeleteRegister(int id)
		{
			var BookingDB = await _context.AppUsers.FindAsync(id);
			if (BookingDB == null)
			{
				return NotFound("This customer could not be found");
			}
			_context.AppUsers.Remove(BookingDB);
			await _context.SaveChangesAsync();

			return await GetAllRegister();
		}

	}
}

