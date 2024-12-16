using OOPProject.Step04.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Step04
{
    internal class Employee : Person
    {
        public Employee(string nationalId, string firstName, string lastName, string email, DateTime birthDay,
            DateTime joinDate, Roles role, decimal basicSalary) 
            : base(nationalId, firstName, lastName, email, birthDay)
        {
            Random random = new Random();
            EmpId = random.Next(100, 111);
            JoinDate = joinDate;
            BasicSalary = basicSalary;
            Role = role;
        }

        //property
        public int EmpId { get; set; }
        public DateTime JoinDate { get; set; }
        public Roles Role {  get; set; }
        public virtual decimal BasicSalary {  get; set; }

        public decimal TotalSalary { get; set; }




       

        public static decimal GetTotalSalary(List<Employee> empList)
        {
            decimal totalSalary = 0;
            foreach (Employee emp in empList)
            {
                totalSalary += emp.TotalSalary;
            }
            return totalSalary;
        }

        public override string? ToString()
        {
            return $"{base.ToString()} | EmpId:{EmpId}| FullName : {FirstName + " " + LastName}|  JoinDate : {JoinDate}| Role : {Role}| Basic Salary : {BasicSalary.ToString("C",new CultureInfo("id-ID"))} ";

        }


    }
}
