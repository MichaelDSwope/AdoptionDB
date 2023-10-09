using Microsoft.EntityFrameworkCore;

namespace AdoptionDB.Models.Data
{

        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            public DbSet<Animal> Animals { get; set; }

        }





}
