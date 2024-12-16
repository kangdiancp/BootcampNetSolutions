using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Step01
{
    internal class Employee
    {
        //set default private
        int empId;
        string firstName;
        string lastName;
        DateTime joinDate;
        string role;
        decimal basicSalary;
        int totalEmployee;
        decimal totalSalary;


        public int EmpId { get => empId; set => empId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public string Role { get => role; set => role = value; }
        public decimal BasicSalary { get => basicSalary; set => basicSalary = value; }


        //empty constructor
        public Employee()
        {
        }

        public Employee(int empId, string firstName, string lastName, DateTime joinDate, string role, decimal basicSalary)
        {
            this.empId = empId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.joinDate = joinDate;
            this.role = role;
            this.basicSalary = basicSalary;
            this.totalSalary = basicSalary;
        }

        public Employee(string firstName, string lastName, DateTime joinDate, string role, decimal basicSalary)
        {
            Random random = new Random();
            this.empId = random.Next(105, 110);
            this.firstName = firstName;
            this.lastName = lastName;
            this.joinDate = joinDate;
            this.role = role;
            this.basicSalary = basicSalary;
            this.totalSalary = basicSalary;
        }

        public static decimal GetTotalSalary(List<Employee> empList)
        {
            decimal totalSalary = 0;
            foreach (Employee emp in empList)
            {
                totalSalary += emp.totalSalary;
            }
            return totalSalary;
        }

        public override string? ToString()
        {
            return $"EmpId:{empId}| FullName : {firstName + " " + lastName}|  JoinDate : {joinDate}| Role : {role}| Basic Salary : {basicSalary} Total Salary : {totalSalary}";

        }


    }
}
