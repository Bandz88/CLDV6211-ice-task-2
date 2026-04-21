using Microsoft.EntityFrameworkCore;
using Kias_Kar_Kompany.Models;

namespace Kias_Kar_Kompany.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}