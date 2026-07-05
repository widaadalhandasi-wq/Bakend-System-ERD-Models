using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Managment_System.Models
{
    // 1. Department Class
    [Table("Department")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-generated
        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string DName { get; set; }

        // Navigation Properties (1:M)
        public List<Faculty> Faculties { get; set; } 
        public List<Course> Courses { get; set; } 
        public List<Exams> Exams { get; set; }
    }
}
