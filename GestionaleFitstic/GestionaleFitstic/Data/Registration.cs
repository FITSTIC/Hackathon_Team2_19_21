using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionaleFitstic.Data
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime RegDate { get; set; }
        [Required]
        public Course Course { get; set; }
        [Required]
        public Student Student { get; set; }
        public Registration()
        { }
    }
}