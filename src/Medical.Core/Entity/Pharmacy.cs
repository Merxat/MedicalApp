using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class Pharmacy:BaseEntity
    {
        public string DrugName { get; set; }
        public decimal Price { get; set; }
        public string Volume { get; set; }
        public ICollection<PharmacyDetails> PharmacyDetails { get; set; }
    }
}
