using System;
using System.ComponentModel.DataAnnotations;

namespace GestionaleFitstic.Data
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime StartDate { get; set; }

        public Staff()
            {}
    }
}
