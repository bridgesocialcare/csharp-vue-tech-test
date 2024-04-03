namespace PatientReferralApi.Domain
{
    public class Referral
    {
        public Referral(string title)
        {
            Id = Guid.NewGuid();
            Title = title;
            CreatedDateTime = DateTime.UtcNow;
        }

        public Guid Id { get; }

        public string Title { get; private set; }

        public DateTime CreatedDateTime { get; }
    }
}
