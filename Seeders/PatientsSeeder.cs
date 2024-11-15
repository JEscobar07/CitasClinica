using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using CitasClinica.Models;
using Microsoft.EntityFrameworkCore;

namespace CitasClinica.Seeders
{
    public class PatientsSeeder
    {

        // Main method to be called from DbContext to populate the database
        public static void Seed(ModelBuilder modelBuilder, int amount)
        {
            var patients = GeneratePatients(amount); // Generate the specified number of patients
            modelBuilder.Entity<Patient>().HasData(patients); // Insert the generated data into the database
        }

        // Method that uses Bogus to generate patients
        public static IEnumerable<Patient> GeneratePatients(int count)
        {
            var faker = new Faker<Patient>()
                .RuleFor(p => p.Id, f => f.IndexFaker + 1) // Generate a unique incremental Id for each patient
                .RuleFor(p => p.Name, f => f.Name.FirstName()) // Generate a random first name
                .RuleFor(p => p.LastName, f => f.Name.LastName()) // Generate a random last name
                .RuleFor(p => p.DateBorn, f => f.Date.Past(30, DateTime.Now.AddYears(-18))) // Generate a random birth date (ensure patients are over 18)
                .RuleFor(p => p.Phone, f => f.Phone.PhoneNumber()) // Generate a random phone number
                .RuleFor(p => p.Email, f => f.Internet.Email()); // Generate a random email address

        // Generate 'count' number of patients
            return faker.Generate(count);
        }
    }
}