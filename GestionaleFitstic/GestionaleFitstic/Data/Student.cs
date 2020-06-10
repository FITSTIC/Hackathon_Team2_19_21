using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionaleFitstic.Data
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        [Required]
        public string DiplomaType { get; set; }
        [Range(2000, 9999)]
        public int DiplomaYear { get; set; }

        public Student()
        { }
    }
}