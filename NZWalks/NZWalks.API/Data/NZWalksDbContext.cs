using Microsoft.EntityFrameworkCore;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Walks> Walks { get; set; }
        public DbSet<Models.Regions> Regions { get; set; }
        public DbSet<Models.Difficulty> Difficulties { get; set; }
    }
}
