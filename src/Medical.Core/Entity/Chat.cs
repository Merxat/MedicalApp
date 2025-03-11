using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class Chat : BaseEntity
    {
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public string VideoZvonokId { get; set; }
        public VideoZvonok VideoZvonok { get; set; }
    }
}
