using System.ComponentModel.DataAnnotations;

namespace HotelverwaltungKlassenbib
{
    public class Room
    {
        [Key]
        public int RommId { get; set; }
        public int ZimmerNr { get; set; }
        public int Betten { get; set; }
        public bool Kueche { get; set; }
        public bool Balkon { get; set; }
        public bool Terrase { get; set; }
        public decimal Price { get; set; }

        //public List<Bill> Bills{get;set;}= new();



    }
}