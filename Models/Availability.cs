using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CitasClinica.Models
{
    [Table("Availabilities")]
    public class Availability
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("date_time")]
        public DateTime DateTime { get; set; }

        [Required]
        [Column("available")]
        public bool Available { get; set; }

        [Column("doctor_id")]
        [Required]
        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; } // Relación con Doctor
    }
}