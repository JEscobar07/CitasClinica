using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.DTOS;
using CitasClinica.Models;

namespace CitasClinica.Repositories
{
    public interface IPatientRepository
    {
        // Method for requesting an appointment
        Task<Appointment> RequestAppointmentAsync(int patientId, AppointmentDTO appointmentRequest);

        // Method for cancelling an appointment
        Task<bool> CancelAppointmentAsync(int patientId, int appointmentId);

        // Method for retrieving appointment history
        Task<IEnumerable<Appointment>> GetAppointmentHistoryAsync(int patientId);
    }
}