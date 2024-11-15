using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.DTOS;
using CitasClinica.Models;

namespace CitasClinica.Repositories
{
    public interface IDoctorRepository
    {
        // Method to update the status of an appointment (e.g., confirm or cancel)
        Task<bool> UpdateAppointmentStatusAsync(int doctorId, int appointmentId, string status);

        // Method to view all scheduled appointments for a doctor
        Task<IEnumerable<Appointment>> GetScheduledAppointmentsAsync(int doctorId);

        // Method to register doctor availability
        Task<Availability> RegisterAvailabilityAsync(int doctorId, AvailabilityDTO availabilityRequest);
    }
}