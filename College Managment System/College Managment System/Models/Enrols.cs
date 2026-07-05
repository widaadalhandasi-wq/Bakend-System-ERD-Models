using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Managment_System.Models
{
    // 6. Enrols Class M:N between Student and Course..
    public class Enrols
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   // Auto-generated
        public int studCourse {  get; set; }
 
      //------------------------------------------------------------------------
        [ForeignKey("Student")]
        public int SId { get; set; }
        public Student Student { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
