using datenbanken2.Models;
using Microsoft.EntityFrameworkCore;

namespace datenbanken2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<mitarbeiterEntity> mitarbeiter { get; set; }
    }
}
