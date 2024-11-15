using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using CitasClinica.Models;
using Microsoft.EntityFrameworkCore;

namespace CitasClinica.Seeders
{
    public class HistoryDatesSeeder
    {
        // Main method to seed data for HistoryDating
        public static void Seed(ModelBuilder modelBuilder,int amount)
        {
            var historyDatings = GenerateHistoryDatings(amount); // Generate exactly 5 history dating entries
            modelBuilder.Entity<HistoryDating>().HasData(historyDatings); // Insert the generated history datings into the database
        }

        // Method that generates history dating data
        public static IEnumerable<HistoryDating> GenerateHistoryDatings(int count)
        {
            var faker = new Faker<HistoryDating>()
                .RuleFor(a => a.Id, f => f.IndexFaker + 1)
                .RuleFor(h => h.DateTime, f => f.Date.Past(1)) // Generate a random past date for the history entry
                .RuleFor(h => h.Reason, f => f.Lorem.Sentence()) // Random reason for the history entry
                .RuleFor(h => h.AppointmentId, f => f.PickRandom(1, 2, 3, 4, 5)); // Pick a random appointment ID from the existing 5 appointments

            return faker.Generate(count); // Generate 'count' number of history dating entries
        }
    }
}