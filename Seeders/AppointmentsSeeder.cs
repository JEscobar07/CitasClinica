using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using CitasClinica.Models;
using Microsoft.EntityFrameworkCore;

namespace CitasClinica.Seeders
{
    public class AppointmentsSeeder
    {
        // Main method to seed data for Appointments
        public static void Seed(ModelBuilder modelBuilder, int amount)
        {
            var appointments = GenerateAppointments(amount); // Generate exactly 5 appointments
            modelBuilder.Entity<Appointment>().HasData(appointments); // Insert the generated appointments into the database
        }

        // Method that generates appointment data
        public static IEnumerable<Appointment> GenerateAppointments(int count)
        {
            var faker = new Faker<Appointment>()
                .RuleFor(a => a.Id, f => f.IndexFaker + 1) // Incremental Id starting from 1
                .RuleFor(a => a.DateTime, f => f.Date.Future(30)) // Generate a future date-time for the appointment
                .RuleFor(a => a.Status, f => f.PickRandom("Scheduled", "Completed", "Cancelled")) // Random appointment status
                .RuleFor(a => a.PatientId, f => f.PickRandom(1, 2, 3, 4, 5)) // Pick a random patient from IDs 1 to 5
                .RuleFor(a => a.DoctorId, f => f.PickRandom(1, 2, 3, 4, 5)); // Pick a random doctor from IDs 1 to 5

            return faker.Generate(count); // Generate 'count' number of appointments
        }
    }
}