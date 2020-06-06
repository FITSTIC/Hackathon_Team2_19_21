using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionaleFitstic.Data
{
    public class StudentService
    {        
        public Task <Student[]> GetStudentAsync(string name, string surname, DateTime birthDate, string address, string city, string email, int phoneNumber, string diplomaType, DateTime diplomaYear)
        {
            return Task.FromResult(Enumerable.Range(1, 10).Select(index => new Student
            {
                Name = name,
                Surname = surname,
                BirthDate = birthDate,
                Address = address,
                City = city,
                Email = email,
                PhoneNumber = phoneNumber,
                DiplomaType = diplomaType,
                DiplomaYear = diplomaYear,
            }).ToArray());
        }
    }
}
