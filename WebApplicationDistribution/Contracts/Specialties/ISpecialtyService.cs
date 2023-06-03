
namespace WebApplicationDistribution.Contracts.Specialties;

public interface ISpecialtyService
{
    Task AddAsync(Specialty modal);
    Task CommitChangesAsync();
    Task DeleteAsync(Specialty modal);
    IEnumerable<Specialty> GetAllSpecialties();
    Task<List<Specialty>> GetRangeAsync(int? page = null, int? pageSize = null, IReadOnlyCollection<int>? readOnlyIds = null, IReadOnlyCollection<int>? readOnlySpecialtyIds = null, IReadOnlyCollection<string>? readOnlyCodes = null, params string[] includes);
    Task UpdateAsync(Specialty modal);
}
