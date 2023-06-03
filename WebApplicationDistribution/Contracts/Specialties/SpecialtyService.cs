using Microsoft.EntityFrameworkCore;
using WebApplicationDistribution.Contracts.Entrants;

namespace WebApplicationDistribution.Contracts.Specialties;

public class SpecialtyService : ISpecialtyService
{
    private EntrantContext _entrantContext;

    public SpecialtyService(EntrantContext entrantContext)
    {
        _entrantContext = entrantContext ?? throw new ArgumentNullException(nameof(_entrantContext));
    }

    //public Entrant GetSpecialtById(int id)
    //{
    //    _entrantContext = _entrantContext.Where(Entrant => _entrantContext.Entrant_Id == id).FirstOrDefault();
    //}


    public Task AddAsync(Specialty modal)
    {
        return _entrantContext.specialities.AddAsync(modal).AsTask();
    }

    public Task CommitChangesAsync()
    {
        return _entrantContext.SaveChangesAsync();
    }

    public Task DeleteAsync(Specialty modal)
    {
        return Task.FromResult(_entrantContext.specialities.Remove(modal));
    }

    public async Task UpdateAsync(Specialty modal)
    {
        var specialty = await _entrantContext.specialities.FindAsync(modal.Spec_Id);

        if (specialty == null)
            return;

        if (specialty.SpecialtyName != modal.SpecialtyName)
        {
            specialty.SpecialtyName = modal.SpecialtyName;
        }

        if (specialty.BudgetSeats != modal.BudgetSeats)
        {
            specialty.BudgetSeats = modal.BudgetSeats;
        }

        if (specialty.PaidSeats != modal.PaidSeats)
        {
            specialty.PaidSeats = modal.PaidSeats;
        }

        await Task.FromResult(_entrantContext.specialities.Update(specialty));

    }

    public Task<List<Specialty>> GetRangeAsync(
        int? page = default,
        int? pageSize = default,
        IReadOnlyCollection<int>? readOnlyIds = default,
        IReadOnlyCollection<int>? readOnlySpecialtyIds = default,
        IReadOnlyCollection<string>? readOnlyCodes = default,
        params string[] includes)
    {
        var query = _entrantContext.specialities.AsQueryable();

        if (readOnlyIds is not null && readOnlyIds.Any())
        {
            query = query.Where(specialty => readOnlyIds!.Contains(specialty.Spec_Id));
        }

        return query.ToListAsync();
    }

    public IEnumerable<Specialty> GetAllSpecialties() => _entrantContext.specialities;
}
