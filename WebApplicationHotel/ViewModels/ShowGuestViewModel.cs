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
    public partial class ShowGuestViewModel
    {

        public ObservableCollection<Guest> Guests { get; set; } = new();

        public ShowGuestViewModel()
        {
            GetGuestsAsync();
        }

        
        public async Task GetGuestsAsync()
        {
            HttpClient client = new HttpClient();
            var guests = await client.GetFromJsonAsync<List<Guest>>("https://localhost:7251/api/Hotelverwaltung/Guests");
            Console.WriteLine(guests);
            guests.ForEach(r => Guests.Add(r));
        }



    }
}
