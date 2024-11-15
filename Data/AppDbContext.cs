
using CitasClinica.Models;
using CitasClinica.Seeders;
using Microsoft.EntityFrameworkCore;

namespace CitasClinica.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<HistoryDating> HistoryDates { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            AdministratorsSeeder.Seed(modelBuilder);
            PatientsSeeder.Seed(modelBuilder,5);
            DoctorsSeeder.Seed(modelBuilder, 5);
            AvailabilitySeeder.Seed(modelBuilder, 5);
            AppointmentsSeeder.Seed(modelBuilder, 5);
            HistoryDatesSeeder.Seed(modelBuilder, 5);
        }
    }
}