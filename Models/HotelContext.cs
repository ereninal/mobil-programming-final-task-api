using Microsoft.EntityFrameworkCore;

namespace HotelApi.Models {
    public class HotelContext : DbContext {

        public DbSet<User> Users { get; set; }
        //public DbSet<Propert> Properts { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder
                .UseSqlServer(@"Data Source = EREN-LAPTOP\SQLEXPRESS;Initial Catalog=HotelDb;Integrated Security=SSPI; ");
        }
        
    }
}