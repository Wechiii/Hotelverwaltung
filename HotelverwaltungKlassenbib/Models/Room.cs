using System.ComponentModel.DataAnnotations;

namespace HotelverwaltungKlassenbib
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public int ZimmerNr { get; set; }
        public int Betten { get; set; }
        public bool Kueche { get; set; }
        public bool Balkon { get; set; }
        public bool Terrasse { get; set; }
        public decimal Preis { get; set; }

        //public List<Bill> Bills{get;set;}= new();



    }
}