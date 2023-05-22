using APi.DB;
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
        [Route("allRooms")]
        public async Task<IActionResult> GetAllArticles()
        {
            return new JsonResult(await this._context.Rooms.ToListAsync());
        }


        [HttpGet]
        [Route("get/{id:int}")]
        public async Task<IActionResult> GetOneArticle(int id)
        {
            return new JsonResult(await this._context.Rooms.FindAsync(id));
        }

        //GUESTS
        //TODO MAUI erledigen --> noch alles erzeugen
        [HttpPost]
        [Route("PostGuest")]
        public async Task<bool> InsertOne(Guest g)
        {
            if (g != null)
            {
                this._context.Guests.Add(g);
                int i = await this._context.SaveChangesAsync();
                if (i > 0) return true;
            }
            return false;
        }
    }
}
