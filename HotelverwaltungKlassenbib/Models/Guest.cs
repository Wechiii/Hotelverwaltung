using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelverwaltungKlassenbib.Models
{
    public  class Guest
    {
        public int GuestId { get; set; }
        public string Firstname { get; set; }
        public string  Lastname { get; set; }
        
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
