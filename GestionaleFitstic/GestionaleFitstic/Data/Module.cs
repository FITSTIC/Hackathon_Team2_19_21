using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionaleFitstic.Data
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Subject { get; set; }        
        public Course Course { get; set; }
        [Required]
        public int? CourseId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public Staff Teacher { get; set; }
        [Required]
        public int? TeacherId { get; set; }
        public Staff Tutor { get; set; }
        [Required]
        public int? TutorId { get; set; }
        public Module()
        { }
    }

    
}