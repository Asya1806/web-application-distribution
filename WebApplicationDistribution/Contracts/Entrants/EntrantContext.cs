using Microsoft.EntityFrameworkCore;
using WebApplicationDistribution.Contracts.Specialties;

namespace WebApplicationDistribution.Contracts.Entrants;

public class EntrantContext : DbContext
{
    public EntrantContext(DbContextOptions<EntrantContext> options) 
        : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Entrant> entrants { get; set; }

    public DbSet<Specialty> specialities { get; set; }

    public DbSet<PassportSeries> passportSeries { get; set; }

    public DbSet<ApplicationForPaid> applicationForPaid { get; set; }

    public DbSet<Gender> genders { get; set; }

    public DbSet<LanguageInUniver> languageInUnivers { get; set; }

    public DbSet<Locality> localities { get; set; }

    public DbSet<LoginRequest> loginRequests { get; set; }

    public DbSet<TypeOfContest> typeOfContests { get; set; }

    public DbSet<YesOrNo> yesOrNo { get; set; }

    public DbSet<Benefit> benefits { get; set; }

    public DbSet<CommissionDecision> commissionDecisions { get; set; }
}
