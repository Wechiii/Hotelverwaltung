using CommunityToolkit.Mvvm.ComponentModel;
using HotelverwaltungKlassenbib;
using System.Net.Http.Json;
using CommunityToolkit.Mvvm.Input;
using WebApplicationHotel.Views;
using System.Collections.ObjectModel;

namespace WebApplicationHotel.ViewModels
{
    // [ObservableObject]
    public partial class ShowRoomsViewModel
    {

        public ObservableCollection<Room> Rooms { get; set; } = new();

        public ShowRoomsViewModel()
        {
            GetRoomAsync();
        }


        public async Task GetRoomAsync()
        {
            HttpClient client = new HttpClient();
            var rooms = await client.GetFromJsonAsync<List<Room>>("https://localhost:7251/api/Hotelverwaltung/allRooms");
            Console.WriteLine(rooms);
            rooms.ForEach(r => Rooms.Add(r));
        }



    }
}
