using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class Ambulance : BaseEntity
    {
        public Geolocation ClientLocation { get; set; }
        public Geolocation AmbulanceLocation { get; set; }
    }
}
