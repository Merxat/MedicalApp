using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class Appointment:BaseEntity
    {
        public DateTime Date { get; set; }
        public Guid Reason { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Guid ApplicationUserId { get; set; }
        public Doctor Doctor { get; set; }
        public Guid DoctorId { get; set; }
        public Payment Payment { get; set; }
    }
}
