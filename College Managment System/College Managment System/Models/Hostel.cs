using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Managment_System.Models
{
    // 3. Hostel Class
    [Table("Hostel")]
    public class Hostel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-generated
        public int HostelId { get; set; }

        [Required]
        [MaxLength(100)]
        public string HostelName { get; set; }

        public int NoOfSeats { get; set; }

        // Navigation Property (1:M with Student)
        public List<Student> Students { get; set; }   
    }
}
