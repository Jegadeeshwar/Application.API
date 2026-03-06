using Application.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Enquiry> Enquiries { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
