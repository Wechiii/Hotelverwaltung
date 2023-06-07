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
        private String feedback;

        [ObservableProperty]
        private String _street;

        [ObservableProperty]
        private int _housenumber;

        [ObservableProperty]
        private int _postalcode;

        public InsertGuestViewModel()
        {
            this.CmdinsertNewGuest = new AsyncRelayCommand(insertNewGuest);
            this.Felderleeren = new AsyncRelayCommand(OnFelderLeeren);
        }

        public IAsyncRelayCommand CmdinsertNewGuest { get; set; }
        public IAsyncRelayCommand Felderleeren { get; set; }

        private async Task insertNewGuest()
        {

            int error = 0;
            if (Firstname == null || Firstname == "")
            {
                error = error + 1;
                this.Feedback = "Vorname fehlt!";
            }
            if (Lastname == null || Lastname == "")
            {
                error = error + 1;
                this.Feedback = "Nachname fehlt!";

            }
            if (Street == null || Street == "")
            {
                error = error + 1;
                this.Feedback = "Strasse fehlt!";

            }
            if (Housenumber == 0)
            {
                error = error + 1;
                this.Feedback = "Hausnummer fehlt!";

            }
            if (Postalcode == 0)
            {
                error = error + 1;
                this.Feedback = "Postleitzahl fehlt!";

            }

            Console.WriteLine(error);

            if (error == 0)
            {
                Guest g = new Guest()
                {
                    Firstname = this.Firstname,
                    Lastname = this.Lastname,

                };

                Address a = new Address()
                {
                    Street = this.Street,
                    Housenumber = this.Housenumber,
                    Postalcode = this.Postalcode,

                };

                g.Addresses.Add(a);

                HttpClient client = new HttpClient();
                HttpResponseMessage m = await client.PostAsJsonAsync<Guest>("https://localhost:7251/api/Hotelverwaltung/PostGuest", g);
                bool succes = Convert.ToBoolean(await m.Content.ReadAsStringAsync());
                this.Feedback = "Gast wurde Eingetragen";
            }
        }

            private Task OnFelderLeeren()
            {
                this.Firstname = null;
                this.Lastname = null;
                this.Housenumber = 0;
                this.Housenumber = 0;
                return Task.CompletedTask;
            }   
    }
}
