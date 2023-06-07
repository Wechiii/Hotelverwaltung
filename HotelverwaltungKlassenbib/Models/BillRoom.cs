using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelverwaltungKlassenbib.Models
{
    public class BillRoom
    {
        public int BillRoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }



        public Bill Bill { get; set; }
        public Room Room { get; set; }
    }
}
