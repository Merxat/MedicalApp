using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class Cart:BaseEntity
    {
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }
        public Guid PaymentDetailsId { get; set; }
        public PharmacyDetails PaymentDetails { get; set; }
        public decimal Total { get; set; }
        public Guid PharmacyPaymentId { get; set; }
        public PharmacyPayment PharmacyPayment { get; set; }
    }
}
