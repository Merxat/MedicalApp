using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class PharmacyDetails:BaseEntity
    {
        public string DrugCount { get; set; }
        public Guid PharmacyId { get; set; }
        public Pharmacy Pharmacy { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; }
        public Guid CartId { get; set; }
        public Cart Cart { get; set; }
    }
}
