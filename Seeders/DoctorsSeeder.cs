using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using CitasClinica.Models;
using Microsoft.EntityFrameworkCore;

namespace CitasClinica.Seeders
{
    public class DoctorsSeeder
    {
        // Main method to be called from DbContext to populate the database
        public static void Seed(ModelBuilder modelBuilder, int amount)
        {
            var doctors = GenerateDoctors(amount); // Generate the specified number of doctors
            modelBuilder.Entity<Doctor>().HasData(doctors); // Insert the generated data into the database
        }

        // Method that uses Bogus to generate doctors
        public static IEnumerable<Doctor> GenerateDoctors(int count)
        {
            var faker = new Faker<Doctor>()
                .RuleFor(d => d.Id, f => f.IndexFaker + 1) // Generate a unique incremental Id for each doctor
                .RuleFor(d => d.Name, f => f.Name.FullName()) // Generate a random full name (first and last)
                .RuleFor(d => d.Specialty, f => f.Name.JobTitle()) // Generate a random job title (e.g., "Cardiologist")
                .RuleFor(d => d.Phone, f => f.Phone.PhoneNumber()) // Generate a random phone number
                .RuleFor(d => d.Email, f => f.Internet.Email()); // Generate a random email address

            // Generate 'count' number of doctors
            return faker.Generate(count);
        }
    }
}