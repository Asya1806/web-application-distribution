namespace WebApplicationDistribution.Contracts.Entrants
{
    public class EntrantService : IEntrantService
    {
        private EntrantContext _entrantContext;
       
        public EntrantService(EntrantContext entrantContext)
        {
            _entrantContext = entrantContext ?? throw new ArgumentNullException(nameof(_entrantContext));
        }

        //public Entrant GetEntrantById (int id)
        //{
        //    _entrantContext = _entrantContext.Where(Entrant => _entrantContext.Entrant_Id == id).FirstOrDefault();
        //}

        public bool AddEntrant(Entrant entrant)
        {
            if(entrant is null)
            {
                throw new ArgumentNullException(nameof(entrant));
            }
            if (_entrantContext.Entrants.Contains(entrant))
            {
                return false;
            }
            _entrantContext.Add(entrant);
            _entrantContext.SaveChanges();
            return true;
        }

        public bool CreateEntrant(string lastName, string firstName, string? middleName, int genderId, int applicationForPaidId, int testMath, int testPhys, int testLang, int middleMark, int sumOfPoints, int markMath, int markPhys, int typeOfContestId, int specialty1Id, int specialty2Id, int specialty3Id, int specialty4Id, int specialty5Id, int specialty6Id, int benefitsId, int langInUniverId, int _100IdeasForBelarusId, int volunteerId, int BRYUId, int medalDSOId, int additionalTraining, int localityId, int passportSeriesId, int passportNumber, string Phone, int commissionDecisionId)
        {
            if (_entrantContext.Entrants.Where(e => e.LastName == lastName).Count() != 0) return false;

            var entrant = new Entrant()
            {
                LastName = lastName,
                FirstName = firstName,
                MiddleName = middleName,
                Gender_Id = genderId,
                ApplicationForPaid_Id = applicationForPaidId,
                TestMath = testMath,
                TestPhys = testPhys,
                TestLang = testLang,
                MiddleMark = middleMark,
                SumOfPoints = sumOfPoints,
                MarkMath = markMath,
                MarkPhys = markPhys,
                TypeOfСontest_Id = typeOfContestId,
                Specialty1_Id = specialty1Id,
                Specialty2_Id = specialty2Id,
                Specialty3_Id = specialty3Id,
                Specialty4_Id = specialty4Id,
                Specialty5_Id = specialty5Id,
                Specialty6_Id = specialty6Id,
                Benefits_Id = benefitsId,
                LangInUniver_Id = langInUniverId,
                _100IdeasForBelarus_Id = _100IdeasForBelarusId,
                Volunteer_Id = volunteerId,
                BRYU_Id = BRYUId,
                MedalDSO_Id = medalDSOId,
                AdditionalTraining = additionalTraining,
                Locality_Id = localityId,
                PassportSeries_Id = passportSeriesId,
                PassportNumber = passportNumber,
                Phone = Phone,
                CommissionDecision_Id = commissionDecisionId,
            };
            _entrantContext.Entrants.Add(entrant);
            return _entrantContext.SaveChanges() == 1;
        }
        
        public IEnumerable<Entrant> GetAllEntrants() => _entrantContext.Entrants;
        
        public bool RemoveEntrant(Entrant entrant)
        {
            if (_entrantContext.Entrants.Contains(entrant))
            {
                _entrantContext.Remove(entrant);
                _entrantContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool TryShowEntrant(int id, out Entrant entrant)
        {
            entrant = _entrantContext.Entrants.Where(e => e.Entrant_Id == id).FirstOrDefault();

            return !(entrant is null);
        }

        public bool ChangeEntrant(Entrant entrant)
        {
            if (entrant is null)
            {
                return false;
            }

            var entrantToUpdate = _entrantContext.Entrants.Where(x => x.Entrant_Id == entrant.Entrant_Id).FirstOrDefault();

            if (entrantToUpdate is null)
            {
                return false;
            }

            entrantToUpdate.LastName = entrant.LastName;
            entrantToUpdate.FirstName = entrant.FirstName;
            entrantToUpdate.MiddleName = entrant.MiddleName;
            entrantToUpdate.Gender_Id = entrant.Gender_Id;
            entrantToUpdate.ApplicationForPaid_Id = entrant.ApplicationForPaid_Id;
            entrantToUpdate.TestMath = entrant.TestMath;
            entrantToUpdate.TestPhys = entrant.MarkPhys;
            entrantToUpdate.TestLang = entrant.TestLang;
            entrantToUpdate.MiddleMark = entrant.MiddleMark;
            entrantToUpdate.SumOfPoints = entrant.SumOfPoints;
            entrantToUpdate.MarkMath = entrant.MarkMath;
            entrantToUpdate.MarkPhys = entrant.MarkPhys;
            entrantToUpdate.TypeOfСontest_Id = entrant.TypeOfСontest_Id;
            entrantToUpdate.Specialty1_Id = entrant.Specialty1_Id;
            entrantToUpdate.Specialty2_Id = entrant.Specialty2_Id;
            entrantToUpdate.Specialty3_Id = entrant.Specialty3_Id;
            entrantToUpdate.Specialty4_Id = entrant.Specialty4_Id;
            entrantToUpdate.Specialty5_Id = entrant.Specialty5_Id;
            entrantToUpdate.Specialty6_Id = entrant.Specialty6_Id;
            entrantToUpdate.LangInUniver_Id = entrant.LangInUniver_Id;
            entrantToUpdate._100IdeasForBelarus_Id = entrant._100IdeasForBelarus_Id;
            entrantToUpdate.Volunteer_Id = entrant.Volunteer_Id;
            entrantToUpdate.BRYU_Id = entrant.BRYU_Id;
            entrantToUpdate.MedalDSO_Id = entrant.MedalDSO_Id;
            entrantToUpdate.AdditionalTraining = entrant.AdditionalTraining;
            entrantToUpdate.Locality_Id = entrant.Locality_Id;
            entrantToUpdate.PassportSeries_Id = entrant.PassportSeries_Id;
            entrantToUpdate.PassportNumber = entrant.PassportNumber;
            entrantToUpdate.Phone = entrant.Phone;
            entrantToUpdate.CommissionDecision_Id = entrant.CommissionDecision_Id;

            return _entrantContext.SaveChanges() == 1;
        }
    }
}
