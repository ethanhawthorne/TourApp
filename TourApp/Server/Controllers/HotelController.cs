using System.ComponentModel.DataAnnotations;
using TourApp.Server.data;
using TourApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TourApp.Client.Pages;

namespace BlazorWebCW1.Server.Controllers
{
    [Route("api")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly DataContext _context;

        public HotelController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("Hotels")]
        public async Task<ActionResult<List<BookHotel>>> GetAllHotelBookings()
        {
            var list = await _context.BHotels.ToListAsync();

            return Ok(list);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<BookHotel>>> GetHotelBookings(int id)
        {
            var BookingDB = await _context.BHotels.FindAsync(id);
            if (BookingDB != null)
            {
                return NotFound("This Hotel doesnt exist");
            }
            return Ok(BookingDB);
        }

        [HttpPost("Hotels")]
        public async Task<ActionResult<List<BookHotel>>> AddmoreHotelBookings(BookHotel Hote)
        {
            _context.BHotels.Add(Hote);
            await _context.SaveChangesAsync();

            return await GetAllHotelBookings();
        }

        [HttpPut("Hotels/{id}")]
        public async Task<ActionResult<List<BookHotel>>> UpdateHotelBooksings(int id, BookHotel Hote)
        {
            var BookingDB = await _context.BHotels.FindAsync(id);
            if (BookingDB != null)
            {
                return NotFound("This Hotel does not exist");
            }
            BookingDB.UsersId = Hote.UsersId;
            BookingDB.HotelID = Hote.HotelID;
            BookingDB.CheckInDate = Hote.CheckInDate;
            BookingDB.CheckOutDate = Hote.CheckOutDate;


            _context.BHotels.Add(BookingDB);
            await _context.SaveChangesAsync();

            return await GetAllHotelBookings();

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<BookHotel>>> DeleteHotelBookings(int id)
        {
            var BookingDB = await _context.BHotels.FindAsync(id);
            if (BookingDB == null)
            {
                return NotFound("This customer could not be found");
            }
            _context.BHotels.Remove(BookingDB);
            await _context.SaveChangesAsync();

            return await GetAllHotelBookings();
        }

    }
}

