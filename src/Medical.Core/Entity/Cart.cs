using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class Cart:BaseEntity
    {
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public decimal Total { get; set; }
        public Guid PharmacyPaymentId { get; set; }
        public PharmacyPayment PharmacyPayment { get; set; }
    }
}
