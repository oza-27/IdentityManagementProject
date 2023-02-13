using IdentityManagementProject.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityManagementProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Login> logins { get; set; }
        public DbSet<Registration> registrations { get; set; }
    }
}
