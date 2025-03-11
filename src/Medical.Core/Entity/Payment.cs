using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class Payment:BaseEntity
    {
        public PaymentMethod PaymentType { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal ConsultationPrice { get; set; }
        public decimal AdminFee { get; set; }
        public Guid AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
    }
}
