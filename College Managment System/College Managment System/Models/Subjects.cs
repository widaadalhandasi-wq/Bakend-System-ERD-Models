using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Managment_System.Models
{
    [Table("Subjects")]
    // 7. Subject Class
    public class Subjects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   // Auto-generated
        public int SubjectId { get; set; }

        [Required]
        [MaxLength(100)]
        public string SubjectName { get; set; }

        // Foreign Key to Faculty (takes)
        [ForeignKey("FacultyId")]
        public int FacultyId { get; set; }

        // Navigation Properties
        public Faculty Faculty { get; set; }
    }
}
