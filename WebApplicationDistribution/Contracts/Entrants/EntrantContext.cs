using Microsoft.EntityFrameworkCore;

namespace WebApplicationDistribution.Contracts.Entrants
{
    public class EntrantContext : DbContext
    {
        public EntrantContext(DbContextOptions<EntrantContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Entrant> Entrants { get; set; }
    }
}
