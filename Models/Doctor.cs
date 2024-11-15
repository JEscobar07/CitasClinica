using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CitasClinica.Models
{

    //Attributes
    [Table("Doctors")]
    public class Doctor
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("name")]
        public string Name { get; set; }

        [StringLength(100)]
        [Column("specialty")]
        public string Specialty { get; set; }

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