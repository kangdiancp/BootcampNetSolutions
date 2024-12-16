using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Step03
{
    internal abstract class Person
    {
        protected Person(string nationalId, string firstName, string lastName, string email, DateTime birthDay)
        {
            NationalId = nationalId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
        }

        public string NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

        public override string? ToString()
        {
            return $"NationalId : {NationalId} | Email : {Email} |BirthDay : {BirthDay.ToShortDateString()}";
        }
    }
}
