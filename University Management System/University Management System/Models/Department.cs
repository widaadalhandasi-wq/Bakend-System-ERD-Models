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
    [Table("Department")]
    [Index(nameof(departmentName), IsUnique = true)] //uniqe
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-generated
        public int departmentId { get; set; }  //system generated

        [Required]
        [MaxLength(100)]
        public string departmentName { get; set; } // user input

        [MaxLength(50)]
        public string? building { get; set; } // user input

        [Required]
        [Range(0.0, double.MaxValue)]
        public decimal budget { get; set; } // user input

        [ForeignKey("Instructor")]
        public int  headInstructorId { get; set; }  //ForeignKey

        //(One-to-One)
        public Instructor HeadInstructor { get; set; }  //Navigation property  =>one department is headed by one instructor

        //(One-to-Many)
        public List<Course> Courses { get; set; } //Navigation property => many courses is belong to  one department 

    }
}
