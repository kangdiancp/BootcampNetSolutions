using OOPProject.Step04.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Step04
{
    internal class EmployeeService : IEmployeeService
    {
        public void DisplayEmployee(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        public List<Employee> GetAll(List<Employee> employees)
        {
            throw new NotImplementedException();
        }

        public Employee GetById(List<Employee> employees, int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> InitDataEmployee()
        {
            //var employees = new List<Employee>();   
            
            var emp2 = new Employee("131", "Kang", "Dian", "kang@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 10_000);
            var emp3 = new Employee("132", "Wini", "Widi", "wini@gmail.com", new DateTime(1999, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 11_000);
            var emp4 = new Employee("133", "Rini", "Mini", "rini@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 12_000);
            var emp5 = new Employee("134", "Yuli", "Yuliana", "yuli@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 10_000);

            var emp6 = new Programmer("135", "Asep", "Dudi", "asep@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 10_000, 5_000);



            return new List<Employee>() { emp2, emp3, emp4, emp5, emp6 };

        }

        public int TotalEmployee(List<Employee> employees)
        {
            throw new NotImplementedException();
        }

        public double TotalSalary(List<Employee> employees)
        {
            throw new NotImplementedException();
        }
    }
}
