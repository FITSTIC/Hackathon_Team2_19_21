using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestionaleFitstic.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<WeatherForecast> Previsioni { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Exam> Exams { get; set; }
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
