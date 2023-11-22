using Microsoft.EntityFrameworkCore;
using RepositoryInit.Models;

namespace RepositoryInit.Data
{
    public class ApplicationDbContext : DbContext
    {

        public virtual DbSet<Incident> incident{ get; set; }
        public virtual DbSet<User> User { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
    }
}
