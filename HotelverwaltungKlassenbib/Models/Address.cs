using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelverwaltungKlassenbib.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public int Housenumber { get; set; }
        public int Postalcode { get; set; }

        public List<Guest> Guests { get; set; } = new List<Guest>();
    }

    
}
