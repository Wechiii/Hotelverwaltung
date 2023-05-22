using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HotelverwaltungKlassenbib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking;


namespace WebApplicationHotel.ViewModels
{
    [ObservableObject]
    public partial class InsertGuestViewModel
    {
        [ObservableProperty]
        private String _firstname;

        [ObservableProperty]
        private String _lastname;

        [ObservableProperty]
        private string _address;

        [ObservableProperty]
        private String feedback;

        public InsertGuestViewModel()
        {
            this.CmdinsertNewGuest = new AsyncRelayCommand(insertNewGuest);
            this.Felderleeren = new AsyncRelayCommand(OnFelderLeeren);
        }

        public IAsyncRelayCommand CmdinsertNewGuest { get; }
        public IAsyncRelayCommand Felderleeren { get; }

        private async Task insertNewGuest()
        {

            int error = 0;
            if (Firstname == null || Firstname == "")
            {
                error = error + 1;
                this.Feedback = "Name darf nicht leer sein";
            }
            if (Lastname == null || Firstname == "")
            {
                error = error + 1;
                this.Feedback = "Name darf nicht leer sein";

            }
            if (Address == null || Firstname == "")
            {
                error = error + 1;
                this.Feedback = "Name darf nicht leer sein";

            }
            Console.WriteLine(error);
            if (error == 0)
            {
                Guest g = new Guest()
                {
                    Vorname = this.Firstname,
                    Nachname = this.Lastname,
                    adress = this.Address
                };

                HttpClient client = new HttpClient();
                HttpResponseMessage m = await client.PostAsJsonAsync<Guest>("https://localhost:7251/api/Hotelverwaltung/PostGuest", g);
                bool succes = Convert.ToBoolean(await m.Content.ReadAsStringAsync());
                this.Feedback = "Guest wurde Eingetragen";

            }

        }

        private Task OnFelderLeeren()
        {
            this.Firstname = null;
            this.Lastname = null;
            this.Address = null;
            return Task.CompletedTask;
        }
    }
}
