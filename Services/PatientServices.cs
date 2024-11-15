using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.Data;
using CitasClinica.DTOS;
using CitasClinica.Models;
using CitasClinica.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CitasClinica.Services
{
    public class PatientServices : IPatientRepository
    {
        private readonly AppDbContext _context;

        public PatientServices(AppDbContext context)
        {
            _context = context;
        }

        // Method to cancel an appointment
        public async Task<bool> CancelAppointmentAsync(int patientId, int appointmentId)
        {
            var appointment = await _context.Appointments
             .FirstOrDefaultAsync(a => a.Id == appointmentId && a.PatientId == patientId);

            if (appointment == null)
                throw new Exception("Appointment not found.");

            appointment.Status = "Cancelled"; // Update status to "Cancelled"
            var availability = _context.Availabilities
                .FirstOrDefault(a => a.DoctorId == appointment.DoctorId && a.DateTime == appointment.DateTime);

            if (availability != null)
                availability.Available = true; // Mark the availability as available again

            await _context.SaveChangesAsync();
            return true;
        }

        // Method to get the appointment history of a patient
        public async Task<IEnumerable<Appointment>> GetAppointmentHistoryAsync(int patientId)
        {
            var appointments = await _context.Appointments
                .Where(a => a.PatientId == patientId)
                .OrderByDescending(a => a.DateTime) // Ordenar por las citas más recientes primero
                .Include(a => a.Patient) // Incluir la entidad Patient
                .Include(a => a.Doctor)  // Incluir la entidad Doctor
                .ToListAsync();

            return appointments;
        }

        // Method to request an appointment
        public async Task<Appointment> RequestAppointmentAsync(int patientId, AppointmentDTO appointmentRequest)
        {
            var patient = await _context.Patients.FindAsync(patientId);
            if (patient == null)
                throw new Exception("Patient not found.");

            var availableAppointment = _context.Availabilities
                .FirstOrDefault(a => a.DoctorId == appointmentRequest.DoctorId &&
                                     a.DateTime == appointmentRequest.DateTime &&
                                     a.Available);

            if (availableAppointment == null)
                throw new Exception("Appointment time is not available.");

            var appointment = new Appointment
            {
                DateTime = appointmentRequest.DateTime,
                Status = "Scheduled", // Initial status
                PatientId = patientId,
                DoctorId = appointmentRequest.DoctorId
            };

            _context.Appointments.Add(appointment);
            availableAppointment.Available = false; // Mark the availability as booked
            await _context.SaveChangesAsync();

            return appointment;
        }
    }
}