using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System.Models
{
    [Table("Instructor")]
    [Index(nameof(email), IsUnique = true)] //uniqe
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //  Auto-generated
        public int instructorId { get; set; }  //system generated

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; }  // user input

        [Required]
        [MaxLength(150)]
        public string email { get; set; } // user input

        [MaxLength(20)] 
        public string officeNumber { get; set; } // user input


        [Required]
        public DateTime hireDate { get; set; } // user input


        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal salary { get; set; } // user input


        [Required]
        [MaxLength(50)]
        public string academicTitle { get; set; } // user input


        // One-to-One Relationship (Optional)
        public Department ? HeadedDepartment { get; set; }  //Navigation property => one instructor is head one department

        //(One-to-Many)
        public List<Course> Courses { get; set; } //Navigation property => indtructor is teach many courses

    }
}
