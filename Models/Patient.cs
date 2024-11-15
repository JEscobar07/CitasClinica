using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CitasClinica.Models
{
    [Table("Patients")]
    public class Patient
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [Column("last_name")]
        public string LastName { get; set; }

        [Required]
        [Column("date_born")]
        public DateTime DateBorn { get; set; }

        [StringLength(100)]
        [Column("phone")]
        public string Phone { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        [Column("email")]
        public string Email { get; set; }
    }
}