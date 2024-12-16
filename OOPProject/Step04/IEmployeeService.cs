using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Step04
{
    internal interface IEmployeeService
    {
        List<Employee> InitDataEmployee();
        List<Employee> GetAll(List<Employee> employees);

        void DisplayEmployee(List<Employee> employees);

        Employee GetById(List<Employee> employees, int id);
        double TotalSalary(List<Employee> employees);
        int TotalEmployee(List<Employee> employees);

    }
}
