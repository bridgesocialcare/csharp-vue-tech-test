using PatientReferralApi.DataAccess;
using PatientReferralApi.Domain;

namespace PatientReferralApi.Services
{
    public class PatientService
    {
        private readonly IPatientRepository _patientRepository = new InMemoryPatientRepository();

        public IEnumerable<Patient> GetAll()
        {
            return _patientRepository.GetAll();
        }
    }
}
