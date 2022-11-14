using BulldogsPortal.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BulldogsPortal.Data
{
    public class RSVPDbContext : DbContext
    {
        public RSVPDbContext(DbContextOptions<RSVPDbContext> options) : base(options)
        {

        }

        public DbSet<RSVP> RSVPs { get; set; }
    }
}
