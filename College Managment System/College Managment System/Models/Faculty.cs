using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Managment_System.Models
{
    // 2. Faculty Class
    [Table("Faculty")]
    public class Faculty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-generated
        public int FId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        [Required]
        public string MobileNo { get; set; }

        // Foreign Key to Department (belongs)
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }           // Navigation Properties

        // Navigation Properties
        public List<Student> Students { get; set; }  // Teaches M Students
        public List<Subjects> Subjects { get; set; }   // Takes M Subjects
    }
}
