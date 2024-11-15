using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.Models;
using Microsoft.EntityFrameworkCore;

namespace CitasClinica.Seeders
{
    public class AdministratorsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>().HasData(
                new Administrator { Id = 1, Email = "admin@myapp.com", Password = "Admin123" }
            );
        }
    }
}