using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class VideoZvonok:BaseEntity
    {
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
