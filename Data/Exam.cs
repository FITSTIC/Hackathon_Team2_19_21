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
        public Student Student { get; set; }
        public Module Module { get; set; }
        public DateTime Date { get; set; }
        public double Grade { get; set; }
        public Exam()
        { }
    }
}
