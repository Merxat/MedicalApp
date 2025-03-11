using Medical.Core.Comman;

namespace Medical.Core.Entity
{
    public class Ambulance : BaseEntity
    {
        public Guid ClientLocationId { get; set; }
        public Geolocation ClientLocation { get; set; }

        public Guid AmbulanceLocationId { get; set; }
        public Geolocation AmbulanceLocation { get; set; }
    }
        
}
