using PatientReferralApi.Domain;

namespace PatientReferralApi.DataAccess
{
    public class InMemoryPatientRepository : IPatientRepository
    {
        private static readonly List<Patient> _patients = new List<Patient>
        {
            new Patient("Boris", "Johnson"),
            new Patient("Liz", "Truss"),
            new Patient("Rishi", "Sunak")
        };

        public IEnumerable<Patient> GetAll()
        {
            return _patients;
        }
    }
}
