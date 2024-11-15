using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CitasClinica.Models
{
    [Table("HistoryDates")]
    public class HistoryDating
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("date_time")]
        public DateTime DateTime { get; set; }

        [StringLength(255)]
        [Column("reason")]
        public string Reason { get; set; }

        [ForeignKey("appointment")]
        [Column("appointment_id")]
        public int AppointmentId { get; set; }

        public Appointment Appointment { get; set; } // Relación con Appointment
    }
}