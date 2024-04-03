namespace PatientReferralApi.Domain
{
    public class Patient
    {
        public Patient(string forename, string surname)
        {
            Id = Guid.NewGuid();
            Forename = forename;
            Surname = surname;
            CreatedDateTime = DateTime.UtcNow;
        }

        public Guid Id { get; }

        public string Forename { get; private set; }

        public string Surname { get; private set; }

        public DateTime CreatedDateTime { get; }

        public List<Referral> Referrals { get; set; } = [];
    }
}
