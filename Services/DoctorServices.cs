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
    public class DoctorServices : IDoctorRepository
    {
        private readonly AppDbContext _context;

        public DoctorServices(AppDbContext context)
        {
            _context = context;
        }

        // Method to get all scheduled appointments for a doctor
        public async Task<IEnumerable<Appointment>> GetScheduledAppointmentsAsync(int doctorId)
        {
            // Get all appointments for the doctor that are not cancelled
            var appointments = await _context.Appointments
                .Where(a => a.DoctorId == doctorId && a.Status != "Cancelled") // Filter by doctorId and status != "Cancelled"
                .OrderBy(a => a.DateTime) // Order by appointment date, earliest first
                .ToListAsync(); // Fetch from database

            return appointments; // Return the list of scheduled appointments
        }

        public async Task<Availability> RegisterAvailabilityAsync(int doctorId, AvailabilityDTO availabilityRequest)
        {
            // Find the doctor by the provided doctorId
            var doctor = await _context.Doctors.FindAsync(doctorId);

            // If the doctor is not found, throw an exception
            if (doctor == null)
                throw new Exception("Doctor not found.");

            // Create a new availability record
            var availability = new Availability
            {
                DoctorId = doctorId,               // Associate the availability with the doctor
                DateTime = availabilityRequest.DateTime, // Set the availability date and time
                Available = true                    // Initially set availability as true (available)
            };

            // Add the new availability record to the database
            _context.Availabilities.Add(availability);
            await _context.SaveChangesAsync(); // Save changes to the database

            // Return the newly created availability
            return availability;
        }

        // Method to update the status of an appointment
        public async Task<bool> UpdateAppointmentStatusAsync(int doctorId, int appointmentId, string status)
        {
            // Attempt to find the appointment by its appointmentId and doctorId
            var appointment = await _context.Appointments.FirstOrDefaultAsync(a => a.Id == appointmentId && a.DoctorId == doctorId);

            // If the appointment is not found, throw an exception
            if (appointment == null)
                throw new Exception("Appointment not found or doctor does not have this appointment.");

            // Update the status of the found appointment
            appointment.Status = status;

            // Save changes to the database
            await _context.SaveChangesAsync();

            return true; // Return true to indicate that the status update was successful
        }
    }
}