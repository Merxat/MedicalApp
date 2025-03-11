using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class PharmacyPayment:BaseEntity
    {
        public PaymentMethod PaymentMethod { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Taxes { get; set; }
        public decimal Total { get; set; }
    }
}
