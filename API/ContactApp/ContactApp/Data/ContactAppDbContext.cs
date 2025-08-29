using ContactApp.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ContactApp.Data
{
    public class ContactAppDbContext : DbContext
    {
        public ContactAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
