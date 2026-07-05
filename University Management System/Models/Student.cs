using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace University_Management_System.Models
{
    [Table("Student")]
    [Index(nameof(email), IsUnique = true)]  //uniqe
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // Auto-generated
        public int studentId { get; set; }    // system generated

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; }  // user input

        [Required]
        [MaxLength(150)]
        public string email { get; set; } // user input

        [MaxLength(20)]
        public string? phoneNumber { get; set; } // user input

        [Required]
        public DateTime dateOfBirth { get; set; }  // user input

        [Required]
        [Range(2000, 2030)]
        public int enrollmentYear { get; set; } // user input

        [Required]
        [Range(0.0, 4.0)]
        [Column(TypeName = "decimal(3,2)")]
        public decimal gpa { get; set; }  // user input

        //  One-to-Many in  Enrollment Table
        public List<Enrollment> Enrollments { get; set; } //Navigation property => A student can have multiple enrollments
    }
}
