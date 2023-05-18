namespace WebApplicationDistribution.Contracts.Entrants
{
    public interface IEntrantService
    {
        bool AddEntrant(Entrant entrant);

        bool RemoveEntrant(Entrant entrant);

        bool CreateEntrant(string lastName, string firstName, string? middleName, int genderId, int applicationForPaidId, int testMath, int testPhys, int testLang, int middleMark, int sumOfPoints, int markMath, int markPhys, int typeOfContestId, int specialty1Id, int specialty2Id, int specialty3Id, int specialty4Id, int specialty5Id, int specialty6Id, int benefitsId, int langInUniverId, int _100IdeasForBelarusId, int volunteerId, int BRYUId, int medalDSOId, int additionalTraining, int localityId, int passportSeriesId, int passportNumber, string Phone, int commissionDecisionId);
        
        bool ChangeEntrant(Entrant entrant);

        bool TryShowEntrant(int entrantId, out Entrant entrant);

        IEnumerable<Entrant> GetAllEntrants();
    }
}
