using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.DTOS;
using CitasClinica.Models;

namespace CitasClinica.Repositories
{
    public interface IAdministratorRepository
    {
        // Method to reschedule an appointment
        Task<Appointment> RescheduleAppointmentAsync(int appointmentId, AppointmentRescheduleDTO rescheduleRequest);

        // Method to view the medical availability of all doctors
        Task<IEnumerable<Availability>> ViewMedicalAvailabilityAsync();
    }
}