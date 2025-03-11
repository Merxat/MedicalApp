using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class Doctor:BaseEntity
    {
        public Guid DoctorCategoryId { get; set; }
        public DoctorCategory DoctorCategory { get; set; }
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Chat> Chats { get; set; }
    }
}
