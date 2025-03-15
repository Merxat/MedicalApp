using Medical.Core.Entity;
using Medical.DataAccess.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.DataAccess.Repository.Impl
{
    public class AppointmentRepo:BaseRepository<Appointment>,IAppointment
    {
        AppointmentRepo(DataBaseContext dataBaseContext):base(dataBaseContext) { }
    }
}
