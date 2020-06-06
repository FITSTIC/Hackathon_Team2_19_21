using System;
using System.ComponentModel.DataAnnotations;

namespace GestionaleFitstic.Data
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public Course()
        { }
    }
}