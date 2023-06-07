using HotelverwaltungKlassenbib;
using HotelverwaltungKlassenbib.Models;
using Microsoft.EntityFrameworkCore;

namespace APi.DB
{
    public class Context: DbContext
    {
        public DbSet<Room>Rooms { get; set; }
        public DbSet<Guest>Guests { get; set; }
        public DbSet<Address>Addresses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;database=hotelverwaltung1;user=root;password=Mawe6184";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
