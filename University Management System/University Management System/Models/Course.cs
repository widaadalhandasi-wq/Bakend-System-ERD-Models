using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace University_Management_System.Models
{
    [Table("Course")]
    [Index(nameof(courseCode), IsUnique = true)] //uniqe
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // Auto-generated
        public int courseId { get; set; }  //system generated

        [Required]
        [MaxLength(10)]
        public string courseCode { get; set; } // user input

        [Required]
        [MaxLength(150)]
        public string courseTitle { get; set; } // user input
        [Required]
        [Range(1, 6)]
        public int creditHours { get; set; } // user input

        [Required]
        [MaxLength(20)]
        public string semesterOffered { get; set; } // user input


        [Required]
        public int departmentId { get; set; }  //ForeignKey

        [ForeignKey(nameof(departmentId))]

        //(One-to-Many)
        public Department Department { get; set; }  //Navigation property => one department has many courses 

       
        public int instructorId { get; set; }  //ForeignKey

        [ForeignKey(nameof(instructorId))]
        //Many-to-One
        public Instructor Instructor { get; set; } //Navigation property  => one instructor is teach many course

        //  One-to-Many in  Enrollment Table
        public List<Enrollment> Enrollments { get; set; } //Navigation property =>courses enroll many students
    }
}