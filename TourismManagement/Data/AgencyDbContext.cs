using Microsoft.EntityFrameworkCore;
using TourismManagement.Models;

namespace TourismManagement.Data
{
    public class AgencyDbContext : DbContext
    {
        public AgencyDbContext(DbContextOptions<AgencyDbContext> options) : base(options)
        { 
        }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Wholesaler> Wholesalers { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}
