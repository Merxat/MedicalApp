using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class PersonalCabinet : BaseEntity
    {
        public long MySaved { get; set; }
        public Guid AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
