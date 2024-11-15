using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitasClinica.DTOS
{
    public class AppointmentRescheduleDTO
    {
        // The new date and time for the appointment
        public DateTime NewDateTime { get; set; }
    }
}