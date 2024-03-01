using ContactDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactDetails.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<UserModel> UserModels { get; set; }
    }
}
