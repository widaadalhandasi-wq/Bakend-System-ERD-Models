using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Managment_System.Models
{
    [Table("Exams")]
    // 8. Exam Class
    public class Exams
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   // Auto-generated
        public int ExamCode { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        [Required]
        [StringLength(50)]
        public string Room { get; set; }

        // Foreign Key to Department (conducts)
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }   //Navigation property
    }
}
