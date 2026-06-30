using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System.Models
{
    [Table("Enrollment")]
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-generated
        public int enrollmentId { get; set; }  //system generated

        [Required]
        public DateTime enrollmentDate { get; set; } // user input


        [MaxLength(2)]
        public string finalGrade { get; set; } // user input

        [Required]
        [MaxLength(20)]
        public enrollmentSatus status { get; set; } = enrollmentSatus.InProgress;     // default value 


        [Required]
        public int studentId { get; set; }  //ForeignKey

        [ForeignKey(nameof(studentId))]

        //(Many-to-One)
        public Student Student { get; set; }  //Navigation property =>students who enroll

        [Required]
        public int courseId { get; set; }  //ForeignKey

        [ForeignKey(nameof(courseId))]

        //(Many-to-One)
        public Course  Course { get; set; } //Navigation property =>course which enroll
    }
}