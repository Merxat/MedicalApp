using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class Appointment:BaseEntity
    {
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public ApplicationUser User { get; set; }
        public Guid UserId { get; set; }
        public Doctor Doctor { get; set; }
        public Guid DoctorId { get; set; }
        public Payment Payment { get; set; }
    }
}
