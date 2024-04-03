using PatientReferralApi.Domain;

namespace PatientReferralApi.DataAccess
{
    public class SqlServerPatientRepository : IPatientRepository
    {
        public IEnumerable<Patient> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
