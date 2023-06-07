using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelverwaltungKlassenbib.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public Guest Guest { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal Price { get; set; }

        public List<BillRoom> BillRooms { get; set; } = new List<BillRoom>();
    }

    
}
