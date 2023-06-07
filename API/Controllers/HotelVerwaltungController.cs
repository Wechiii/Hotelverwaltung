using APi.DB;
using HotelverwaltungKlassenbib;
using HotelverwaltungKlassenbib.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/Hotelverwaltung")]
    [ApiController]
    public class HotelVerwaltungController
    {
        private readonly Context _context = new Context();

        //Rooms
        [HttpGet]
        [Route("Rooms")]
        public async Task<IActionResult> GetAllRooms()
        {
            return new JsonResult(await this._context.Rooms.ToListAsync<Room>());
        }

        [HttpGet]
        [Route("Guests")]
        public async Task<IActionResult> GetAllGuests()
        {
            return new JsonResult(await this._context.Guests.ToListAsync<Guest>());
        }



        [HttpGet]
        [Route("get/{id:int}")]
        public async Task<IActionResult> GetOneArticle(int id)
        {
            return new JsonResult(await this._context.Rooms.FindAsync(id));
        }



        [HttpPost]
        [Route("PostGuest")]
        public async Task<bool> InsertGuest(Guest g)
        {
            if (g != null)
            {
                this._context.Addresses.Add(g.Addresses.First());
                this._context.Guests.Add(g);
                int i = await this._context.SaveChangesAsync();
                if (i > 0) return true;
            }
            return false;
        }

        [HttpPost]
        [Route("PostAddress")]
        public async Task<bool> InsertAddress(Address a)
        {
            if (a != null)
            {
                this._context.Addresses.Add(a);
                int i = await this._context.SaveChangesAsync();
                if (i > 0) return true;
            }
            return false;
        }
    }
}
