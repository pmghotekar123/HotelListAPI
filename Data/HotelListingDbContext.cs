using Microsoft.EntityFrameworkCore;

namespace HotelListAPI.Data
{
    public class HotelListingDbContext :DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
               
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Pranoti",
                    ShortName = "Po"
                },
                new Country
                {
                    Id = 2,
                    Name = "Priya",
                    ShortName = "Pi"
                },
                new Country
                {
                    Id = 3,
                    Name = "Pooja",
                    ShortName = "Poo"
                }
             );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "7 Star Hotel",
                    Address = "Nagpur",
                    CountryId = 1,
                    Rating = 4.5
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "5 Star Hotel",
                     Address = "Mumbai",
                     CountryId = 3,
                     Rating = 4.3
                 },
                  new Hotel
                  {
                      Id = 3,
                      Name = "Blue Star Hotel",
                      Address = "Pune",
                      CountryId = 2,
                      Rating = 4
                  }
                );

        }
    }
}
