using CommunityToolkit.Mvvm.ComponentModel;
using System.Net.Http.Json;
using CommunityToolkit.Mvvm.Input;
using WebApplicationHotel.Views;
using System.Collections.ObjectModel;
using HotelverwaltungKlassenbib;

namespace WebApplicationHotel.ViewModels
{
    // [ObservableObject]
    public partial class ShowRoomsViewModel
    {

        public ObservableCollection<Room> Rooms { get; set; } = new();

        public ShowRoomsViewModel()
        {
            GetRoomsAsync();
        }


        public async Task GetRoomsAsync()
        {
            HttpClient client = new HttpClient();
            var rooms = await client.GetFromJsonAsync<List<Room>>("https://localhost:7251/api/Hotelverwaltung/Rooms");
            Console.WriteLine(rooms);
            rooms.ForEach(r => Rooms.Add(r));
        }



    }
}
