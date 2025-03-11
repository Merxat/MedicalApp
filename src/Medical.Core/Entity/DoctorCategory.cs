using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class DoctorCategory:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
