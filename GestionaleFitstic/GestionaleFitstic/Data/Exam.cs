using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionaleFitstic.Data
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Student Student { get; set; }
        public int? StudentId {get;set;}
        [Required]
        public Module Module { get; set; }
        public int? ModuleId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Range(0, 100)]
        public int Grade { get; set; }
        public Exam()
        { }
    }
}
