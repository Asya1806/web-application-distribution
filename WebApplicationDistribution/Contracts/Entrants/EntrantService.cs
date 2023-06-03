using Microsoft.EntityFrameworkCore;

namespace WebApplicationDistribution.Contracts.Entrants;

public class EntrantService : IEntrantService
{
    private EntrantContext _entrantContext;

    public EntrantService(EntrantContext entrantContext)
    {
        _entrantContext = entrantContext ?? throw new ArgumentNullException(nameof(_entrantContext));
    }

    public Task AddAsync(Entrant entrant)
    {
        return _entrantContext.entrants.AddAsync(entrant).AsTask();
    }

    public Task CommitChangesAsync()
    {
        return _entrantContext.SaveChangesAsync();
    }

    public Task DeleteAsync(Entrant entrant)
    {
        return Task.FromResult(_entrantContext.entrants.Remove(entrant));
    }

    public async Task UpdateAsync(Entrant entrantModal)
    {
        var entrant = await _entrantContext.entrants.FindAsync(entrantModal.Entrant_Id);

        if (entrant == null)
        {
            return;
        }

        if (entrant.LastName != entrantModal.LastName)
        {
            entrant.LastName = entrantModal.LastName;
        }

        if (entrant.FirstName != entrantModal.FirstName)
        {
            entrant.FirstName = entrantModal.FirstName;
        }

        if (entrant.MiddleName != entrantModal.MiddleName)
        {
            entrant.MiddleName = entrantModal.MiddleName;
        }

        if (entrant.Gender_Id != entrantModal.Gender_Id)
        {
            entrant.Gender_Id = entrantModal.Gender_Id;
        }

        if (entrant.ApplicationForPaid_Id != entrantModal.ApplicationForPaid_Id)
        {
            entrant.ApplicationForPaid_Id = entrantModal.ApplicationForPaid_Id;
        }

        if (entrant.TestMath != entrantModal.TestMath)
        {
            entrant.TestMath = entrantModal.TestMath;
        }

        if (entrant.TestPhys != entrantModal.TestPhys)
        {
            entrant.TestPhys = entrantModal.TestPhys;
        }

        if (entrant.TestLang != entrantModal.TestLang)
        {
            entrant.TestLang = entrantModal.TestLang;
        }

        if (entrant.MiddleMark != entrantModal.MiddleMark)
        {
            entrant.MiddleMark = entrantModal.MiddleMark;
        }

        if (entrant.SumOfPoints != entrantModal.SumOfPoints)
        {
            entrant.SumOfPoints = entrantModal.SumOfPoints;
        }

        if (entrant.MarkMath != entrantModal.MarkMath)
        {
            entrant.MarkMath = entrantModal.MarkMath;
        }

        if (entrant.MarkPhys != entrantModal.MarkPhys)
        {
            entrant.MarkPhys = entrantModal.MarkPhys;
        }

        if (entrant.TypeOfСontest_Id != entrantModal.TypeOfСontest_Id)
        {
            entrant.TypeOfСontest_Id = entrantModal.TypeOfСontest_Id;
        }

        if (entrant.Specialty1_Id != entrantModal.Specialty1_Id)
        {
            entrant.Specialty1_Id = entrantModal.Specialty1_Id;
        }

        if (entrant.Specialty2_Id != entrantModal.Specialty2_Id)
        {
            entrant.Specialty2_Id = entrantModal.Specialty2_Id;
        }

        if (entrant.Specialty3_Id != entrantModal.Specialty3_Id)
        {
            entrant.Specialty3_Id = entrantModal.Specialty3_Id;
        }

        if (entrant.Specialty4_Id != entrantModal.Specialty4_Id)
        {
            entrant.Specialty4_Id = entrantModal.Specialty4_Id;
        }

        if (entrant.Specialty5_Id != entrantModal.Specialty5_Id)
        {
            entrant.Specialty5_Id = entrantModal.Specialty5_Id;
        }

        if (entrant.Specialty6_Id != entrantModal.Specialty6_Id)
        {
            entrant.Specialty6_Id = entrantModal.Specialty6_Id;
        }

        if (entrant.Benefits_Id != entrantModal.Benefits_Id)
        {
            entrant.Benefits_Id = entrantModal.Benefits_Id;
        }

        if (entrant.LangInUniver_Id != entrantModal.LangInUniver_Id)
        {
            entrant.LangInUniver_Id = entrantModal.LangInUniver_Id;
        }

        if (entrant._100IdeasForBelarus_Id != entrantModal._100IdeasForBelarus_Id)
        {
            entrant._100IdeasForBelarus_Id = entrantModal._100IdeasForBelarus_Id;
        }

        if (entrant.Volunteer_Id != entrantModal.Volunteer_Id)
        {
            entrant.Volunteer_Id = entrantModal.Volunteer_Id;
        }

        if (entrant.BRYU_Id != entrantModal.BRYU_Id)
        {
            entrant.BRYU_Id = entrantModal.BRYU_Id;
        }

        if (entrant.MedalDSO_Id != entrantModal.MedalDSO_Id)
        {
            entrant.MedalDSO_Id = entrantModal.MedalDSO_Id;
        }

        if (entrant.AdditionalTraining != entrantModal.AdditionalTraining)
        {
            entrant.AdditionalTraining = entrantModal.AdditionalTraining;
        }

        if (entrant.Locality_Id != entrantModal.Locality_Id)
        {
            entrant.Locality_Id = entrantModal.Locality_Id;
        }

        if (entrant.PassportSeries_Id != entrantModal.PassportSeries_Id)
        {
            entrant.PassportSeries_Id = entrantModal.PassportSeries_Id;
        }

        if (entrant.PassportNumber != entrantModal.PassportNumber)
        {
            entrant.PassportNumber = entrantModal.PassportNumber;
        }

        if (entrant.Phone != entrantModal.Phone)
        {
            entrant.Phone = entrantModal.Phone;
        }

        if (entrant.CommissionDecision_Id != entrantModal.CommissionDecision_Id)
        {
            entrant.CommissionDecision_Id = entrantModal.CommissionDecision_Id;
        }

        await Task.FromResult(_entrantContext.entrants.Update(entrant));
    }

    public Task<List<Entrant>> GetRangeAsync(
        int? page = default,
        int? pageSize = default,
        IReadOnlyCollection<int>? readOnlyIds = default,
        IReadOnlyCollection<int>? readOnlySpecialtyIds = default,
        IReadOnlyCollection<string>? readOnlyCodes = default,
        params string[] includes)
    {
        var query = _entrantContext.entrants.AsQueryable();

        if (readOnlyIds is not null && readOnlyIds.Any())
        {
            query = query.Where(entrant => readOnlyIds!.Contains(entrant.Entrant_Id));
        }

        return query.ToListAsync();
    }

    public IEnumerable<Entrant> GetAllEntrants() => _entrantContext.entrants;

    List<Entrant> _entrantBySpec_1 = new List<Entrant>();
    List<Entrant> _entrantBySpec_2 = new List<Entrant>();
    List<Entrant> _entrantBySpec_3 = new List<Entrant>();
    List<Entrant> _entrantBySpec_4 = new List<Entrant>();
    List<Entrant> _entrantBySpec_5 = new List<Entrant>();
    List<Entrant> _entrantBySpec_6 = new List<Entrant>();

    public IEnumerable<Entrant> EntrantSort(Entrant entrant) =>
        _entrantContext.entrants.OrderBy(e => e.TypeOfСontest_Id).OrderByDescending(a => a.SumOfPoints)
            .ThenByDescending(a => a.TestMath).ThenByDescending(a => a.TestPhys)
            .ThenByDescending(a => a.MiddleMark).ToList();

    public List<int> listSeatsBudget()
    {
        var Seats = new List<int>();
        Seats.Add(_entrantContext.specialities.Where(s => s.Spec_Id == 1).FirstOrDefault().BudgetSeats);
        Seats.Add(_entrantContext.specialities.Where(s => s.Spec_Id == 2).FirstOrDefault().BudgetSeats);
        Seats.Add(_entrantContext.specialities.Where(s => s.Spec_Id == 3).FirstOrDefault().BudgetSeats);
        Seats.Add(_entrantContext.specialities.Where(s => s.Spec_Id == 4).FirstOrDefault().BudgetSeats);
        Seats.Add(_entrantContext.specialities.Where(s => s.Spec_Id == 5).FirstOrDefault().BudgetSeats);
        Seats.Add(_entrantContext.specialities.Where(s => s.Spec_Id == 6).FirstOrDefault().BudgetSeats);
        return Seats;
    }
    public List<int> listSeatsPaid()
    {
        var Seats = new List<int>();
        Seats.Add(_entrantContext.specialities.Where(s => s.Spec_Id == 1).FirstOrDefault().PaidSeats);
        Seats.Add(_entrantContext.specialities.Where(s => s.Spec_Id == 2).FirstOrDefault().PaidSeats);
        Seats.Add(_entrantContext.specialities.Where(s => s.Spec_Id == 3).FirstOrDefault().PaidSeats);
        Seats.Add(_entrantContext.specialities.Where(s => s.Spec_Id == 4).FirstOrDefault().PaidSeats);
        Seats.Add(_entrantContext.specialities.Where(s => s.Spec_Id == 5).FirstOrDefault().PaidSeats);
        Seats.Add(_entrantContext.specialities.Where(s => s.Spec_Id == 6).FirstOrDefault().PaidSeats);
        return Seats;
    }



    /// <summary>
    /// 400101, 400501-01, 400501-04, Автоматизация, Роботы
    /// </summary>
    /// <param name="seats"></param>
    public List<List<Entrant>> DistributionEntrant(List<int> specialtyIds, List<int> seats, int applicationforPaidId)
    {
        var toAdd = new List<List<Entrant>>();

        foreach (int id in specialtyIds)
        {
            toAdd.Add(new List<Entrant>());
        }

            var benifits = _entrantContext.entrants.Where(x => x.ApplicationForPaid_Id == applicationforPaidId).Where(x => x.TypeOfСontest_Id == 1 || x.TypeOfСontest_Id == 2 || x.TypeOfСontest_Id == 3).ToList();

        for (int i = 0; i < seats.Count; i++)
        {
            toAdd[i].AddRange(benifits.Where(x => x.Specialty1_Id == specialtyIds[i]));
            seats[i] -= toAdd[i].Count;
        }

        var entrantByContest = _entrantContext.entrants.Where(x => x.ApplicationForPaid_Id == applicationforPaidId).Where(x => x.TypeOfСontest_Id == 4).OrderByDescending(a => a.SumOfPoints)
            .ThenByDescending(a => a.TestMath).ThenByDescending(a => a.TestPhys)
            .ThenByDescending(a => a.MiddleMark).ToList();

        var count = seats.Sum(x => x);

        foreach (var entrant in entrantByContest)
        {
            if (count == 0)
            {
                break;
            }

            var firstSpesialty = specialtyIds.IndexOf(entrant.Specialty1_Id);

            if (seats[firstSpesialty] > 0)
            {
                toAdd[firstSpesialty].Add(entrant);
                seats[firstSpesialty] -= 1;
                count -= 1;
                continue;
            }

            if (entrant.Specialty2_Id == 7)
            {
                continue;
            }

            var secondSpesialty = specialtyIds.IndexOf(entrant.Specialty2_Id);

            if (seats[secondSpesialty] > 0)
            {
                toAdd[secondSpesialty].Add(entrant);
                seats[secondSpesialty] -= 1;
                count -= 1;
                continue;
            }

            if (entrant.Specialty3_Id == 7)
            {
                continue;
            }

            var thirdSpesialty = specialtyIds.IndexOf(entrant.Specialty3_Id);

            if (seats[thirdSpesialty] > 0)
            {
                toAdd[thirdSpesialty].Add(entrant);
                seats[thirdSpesialty] -= 1;
                count -= 1;
                continue;
            }

            if (entrant.Specialty4_Id == 7)
            {
                continue;
            }

            var forthsSpesialty = specialtyIds.IndexOf(entrant.Specialty4_Id);

            if (seats[forthsSpesialty] > 0)
            {
                toAdd[forthsSpesialty].Add(entrant);
                seats[forthsSpesialty] -= 1;
                count -= 1;
                continue;
            }

            if (entrant.Specialty5_Id == 7)
            {
                continue;
            }

            var fiveSpesialty = specialtyIds.IndexOf(entrant.Specialty5_Id);

            if (seats[fiveSpesialty] > 0)
            {
                toAdd[fiveSpesialty].Add(entrant);
                seats[fiveSpesialty] -= 1;
                count -= 1;
                continue;
            }

            if (entrant.Specialty6_Id == 7)
            {
                continue;
            }

            var sixSpesialty = specialtyIds.IndexOf(entrant.Specialty6_Id);

            if (seats[sixSpesialty] > 0)
            {
                toAdd[sixSpesialty].Add(entrant);
                seats[sixSpesialty] -= 1;
                count -= 1;
                continue;
            }
        }

        return toAdd;
    }

    public List<Entrant> CommissionDecision()
    {
        List<List<Entrant>> listEntrantBudget = DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, listSeatsBudget(), 1);
        List<List<Entrant>> listEntrantPaid = DistributionEntrant(new List<int> { 1, 2, 3, 4, 5, 6 }, listSeatsPaid(), 2);

        var listAllEntrant = _entrantContext.entrants.ToList();

        foreach (var entrant in listAllEntrant)
        {
            entrant.CommissionDecision_Id = 2;

        }

        foreach (List<Entrant> listEntrants in listEntrantBudget)
        {
            foreach (Entrant entrant in listEntrants)
            {
                var id = listAllEntrant.IndexOf(entrant);
                listAllEntrant[id].CommissionDecision_Id = 1;
            }
        }
        foreach (List<Entrant> listEntrants in listEntrantPaid)
        {
            foreach (Entrant entrant in listEntrants)
            {
                var id = listAllEntrant.IndexOf(entrant);
                listAllEntrant[id].CommissionDecision_Id = 1;
            }
        }

        return listAllEntrant;
    }

    public void CheckBySeats(Entrant entrant, List<Entrant> entrantBySpec, int seats)
    {
        var toAdd = entrantBySpec.Where(x => x.TypeOfСontest_Id == 1 || x.TypeOfСontest_Id == 2 || x.TypeOfСontest_Id == 3).ToList();

        var count = seats - toAdd.Count();

        toAdd.AddRange(entrantBySpec.Where(x => x.TypeOfСontest_Id == 4).OrderByDescending(a => a.SumOfPoints)
            .ThenByDescending(a => a.TestMath).ThenByDescending(a => a.TestPhys)
            .ThenByDescending(a => a.MiddleMark).ToList().Take(count));
    }
}
