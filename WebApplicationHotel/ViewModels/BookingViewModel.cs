using HotelverwaltungKlassenbib;
using HotelverwaltungKlassenbib.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationHotel.ViewModels
{
    public partial class BookingViewModel
    {

        public ObservableCollection<Room> Rooms { get; set; } = new();
        public ObservableCollection<Guest> Guests { get; set; } = new();

        public BookingViewModel()
        {
            BookingAsync();
        }


        public async Task BookingAsync()
        {
            HttpClient client = new HttpClient();
            var rooms = await client.GetFromJsonAsync<List<Room>>("https://localhost:7251/api/Hotelverwaltung/Rooms");
            Console.WriteLine(rooms);
            rooms.ForEach(r => Rooms.Add(r));

            var guests = await client.GetFromJsonAsync<List<Guest>>("https://localhost:7251/api/Hotelverwaltung/Guests");
            Console.WriteLine(guests);
            guests.ForEach(g => Guests.Add(g));
        }
    }
}
