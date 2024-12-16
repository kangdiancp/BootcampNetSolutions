using OOPProject.Step02.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Step02
{
    internal class Programmer : Employee
    {
        public Programmer(string firstName, string lastName, DateTime joinDate, Roles role, decimal basicSalary,decimal transportasi) 
            : base(firstName, lastName, joinDate, role, basicSalary)
        {
            Transportasi = transportasi;
            TotalSalary = basicSalary + transportasi;
        }

        public decimal Transportasi { get; set; }
        public override decimal BasicSalary
        {
            get => base.BasicSalary;
            set
            {
                base.BasicSalary = value;
                TotalSalary = BasicSalary + Transportasi;
            }
        }

        public override string? ToString()
        {
            return $"{base.ToString()} | Transportasi : {Transportasi.ToString("C", new CultureInfo("id-ID"))}| Total Salary : {TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
