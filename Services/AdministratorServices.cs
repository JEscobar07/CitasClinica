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
    public class AdministratorServices: IAdministratorRepository
    {
        private readonly AppDbContext _context;

        public AdministratorServices(AppDbContext context)
        {
            _context = context;
        }

        // Method to reschedule an appointment
        // Method to reschedule an appointment
        public async Task<Appointment> RescheduleAppointmentAsync(int appointmentId, AppointmentRescheduleDTO rescheduleRequest)
        {
            // Retrieve the appointment by its ID
            var appointment = await _context.Appointments
                .FirstOrDefaultAsync(a => a.Id == appointmentId);

            // If the appointment is not found, throw an exception
            if (appointment == null)
                throw new Exception("Appointment not found.");

            // Check if the new date and time are available for the doctor
            var availability = _context.Availabilities
                .FirstOrDefault(a => a.DoctorId == appointment.DoctorId && a.DateTime == rescheduleRequest.NewDateTime && a.Available);

            // If the new date and time are not available, throw an exception
            if (availability == null)
                throw new Exception("The new date and time are not available for this doctor.");

            // Update the appointment's date and time
            appointment.DateTime = rescheduleRequest.NewDateTime;

            // Mark the new availability as unavailable
            availability.Available = false;

            // Save changes to the database
            await _context.SaveChangesAsync();

            // Return the updated appointment
            return appointment;
        }

        // Method to view medical availability of all doctors
        public async Task<IEnumerable<Availability>> ViewMedicalAvailabilityAsync()
        {
            // Retrieve all available slots from the database, ordered by the date and time
            var availabilities = await _context.Availabilities
                .Where(a => a.Available) // Only fetch available time slots
                .OrderBy(a => a.DateTime) // Order the slots by date and time
                .Include(a => a.Doctor) // Include the doctor information in the response
                .ToListAsync();

            return availabilities;
        }
    }

}