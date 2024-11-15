using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitasClinica.DTOS
{
    public class AppointmentDTO
    {
        // ID of the doctor for the appointment
        public int DoctorId { get; set; }

        // Requested date and time for the appointment
        public DateTime DateTime { get; set; }
    }

}