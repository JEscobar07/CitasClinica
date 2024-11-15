using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using CitasClinica.Models;
using Microsoft.EntityFrameworkCore;

namespace CitasClinica.Seeders
{
    public class AvailabilitySeeder
    {
        // Main method to seed data for Availability
        public static void Seed(ModelBuilder modelBuilder,int amount)
        {
            var availabilities = GenerateAvailabilities(amount); // Generate exactly 5 availabilities
            modelBuilder.Entity<Availability>().HasData(availabilities); // Insert the generated availabilities into the database
        }

        // Method that generates availability data
        public static IEnumerable<Availability> GenerateAvailabilities(int count)
        {
            var faker = new Faker<Availability>()
                .RuleFor(a => a.Id, f => f.IndexFaker + 1) // Incremental Id starting from 1
                .RuleFor(a => a.DateTime, f => f.Date.Future(30)) // Generate a future date-time for availability
                .RuleFor(a => a.Available, f => f.Random.Bool()) // Randomly generate availability (true or false)
                .RuleFor(a => a.DoctorId, f => f.PickRandom(1, 2, 3, 4, 5)); // Pick a random doctor from the list of doctor IDs

            return faker.Generate(count); // Generate 'count' number of availabilities
        }
    }
}