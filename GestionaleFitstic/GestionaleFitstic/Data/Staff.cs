using Microsoft.AspNetCore.SignalR;
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
        [EmailAddress] [Required]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public JobType Jobs { get; set; }
        public DateTime StartDate { get; set; }
        
        public Staff()
        {
        }
    }
    public enum JobType { Insegnante, Tutor, Amministratore }
    
    
}