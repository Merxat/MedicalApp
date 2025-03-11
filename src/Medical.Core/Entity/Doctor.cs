using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class Doctor : BaseEntity
    {
        public string FullName { get; set; } 
        public string DoctorCategoryId { get; set; }
        public DoctorCategory DoctorCategory { get; set; }
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Chat> Chats { get; set; }
    }

}
