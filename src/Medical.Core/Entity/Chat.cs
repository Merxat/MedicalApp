using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class Chat : BaseEntity
    {
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public Guid VideoZvonokId { get; set; }
        public VideoZvonok VideoZvonok { get; set; }
    }
}
