
namespace WebApplicationDistribution.Contracts.Entrants
{
    public interface IEntrantService
    {
        Task AddAsync(Entrant entrant);
        void CheckBySeats(Entrant entrant, List<Entrant> entrantBySpec, int seats);
        List<Entrant> CommissionDecision();
        Task CommitChangesAsync();
        Task DeleteAsync(Entrant entrant);
        List<List<Entrant>> DistributionEntrant(List<int> specialtyIds, List<int> seats, int applicationforPaidId);
        IEnumerable<Entrant> EntrantSort(Entrant entrant);
        IEnumerable<Entrant> GetAllEntrants();
        Task<List<Entrant>> GetRangeAsync(int? page = null, int? pageSize = null, IReadOnlyCollection<int>? readOnlyIds = null, IReadOnlyCollection<int>? readOnlySpecialtyIds = null, IReadOnlyCollection<string>? readOnlyCodes = null, params string[] includes);
        List<int> listSeatsBudget();
        List<int> listSeatsPaid();
        Task UpdateAsync(Entrant entrantModal);
    }
}