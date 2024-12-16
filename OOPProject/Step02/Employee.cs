using OOPProject.Step02.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Step02
{
    internal class Employee
    {
        //property
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoinDate { get; set; }
        public Roles Role {  get; set; }
        public virtual decimal BasicSalary {  get; set; }

        public decimal TotalSalary { get; set; }



        //empty constructor
        public Employee()
        {
        }

        public Employee(int empId, string firstName, string lastName, DateTime joinDate, Roles role, decimal basicSalary)
        {
            EmpId = empId;
            FirstName = firstName;
            LastName = lastName;
            JoinDate = joinDate;
            Role = role;
            BasicSalary = basicSalary;
            TotalSalary = basicSalary;
        }

        public Employee(string firstName, string lastName, DateTime joinDate, Roles role, decimal basicSalary)
        {
            Random random = new Random();
            EmpId = random.Next(105, 110);
            FirstName = firstName;
            LastName = lastName;
            JoinDate = joinDate;
            Role = role;
            BasicSalary = basicSalary;
            TotalSalary = basicSalary;
        }

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
            return $"EmpId:{EmpId}| FullName : {FirstName + " " + LastName}|  JoinDate : {JoinDate}| Role : {Role}| Basic Salary : {BasicSalary.ToString("C",new CultureInfo("id-ID"))} ";

        }


    }
}
