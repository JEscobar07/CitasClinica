using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CitasClinica.Models
{
    [Table("Appointments")]
    public class Appointment
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("date_time")]
        public DateTime DateTime { get; set; }

        [StringLength(50)]
        [Column("status")]
        public string Status { get; set; }

        [Column("patient_id")]
        public int PatientId { get; set; }

        [Column("doctor_id")]
        public int DoctorId { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; } 

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; } 
    }
}