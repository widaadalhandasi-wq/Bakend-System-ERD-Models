using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Managment_System.Models
{
    [Table("Student")]
    // 4. Student Class
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   // Auto-generated
        public int SId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LName { get; set; }

 
        public string? PhoneNo { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        // Derived Attribute (Not Mapped to DB)
        [NotMapped]
        public int Age {  get; set; }

        // Address Composite Attributes
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string PinCode { get; set; }

        // Foreign Key to Hostel (living)
        [ForeignKey("HostelId")]
        public int? HostelId { get; set; }
        public Hostel Hostel { get; set; }            // Navigation Properties

        // Foreign Key to Faculty (teaches)
        [ForeignKey("FacultyId")]              
        public int? FacultyId { get; set; }
        public Faculty Faculty { get; set; }        // Navigation Properties

        // Many-to-Many Relationship with Course
        public List<Enrols> Enrolments { get; set; }     // Navigation Properties
    }
}
