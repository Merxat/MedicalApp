using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class DoctorDetails:BaseEntity
    {
        public string UserName { get; set; }
        public float AverageStars { get; set; }
        public string About { get; set; }
        public DateTime StartWorking { get; set; }
        public DateTime EndWorking { get; set; }
        public Guid ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}
