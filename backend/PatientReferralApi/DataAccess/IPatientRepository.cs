using PatientReferralApi.Domain;

namespace PatientReferralApi.DataAccess
{
    public interface IPatientRepository
    {
        public IEnumerable<Patient> GetAll();
    }
}
