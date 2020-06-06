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
        public DateTime RegDate { get; set; }
        public Course Course { get; set; }
        public Student student { get; set; }        
        public Registration()
        { }

    }
}
