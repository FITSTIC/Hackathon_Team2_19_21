using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionaleFitstic.Data
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        public string Email { get; set; }
        [Range(9, 9)]
        public string PhoneNumber { get; set; }
        public DateTime StartDate { get; set; }

        public Staff()
        { }
    }
}