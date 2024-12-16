
using OOPProject.Step04;

namespace OOPProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // final design, using interface
            // call dulu nama interface
            IEmployeeService employeeService = new EmployeeService();
            var employees = employeeService.InitDataEmployee();
            employeeService.DisplayEmployee(employees);

            
            
            //create object use empty constructor
            /*Employee emp1 = new Employee();
            emp1.EmpId = 1;
            emp1.FirstName="Test";
            emp1.LastName = "Code";
            emp1.JoinDate = new DateTime(2021, 12, 12);
            emp1.Role = Roles.HR;
            emp1.BasicSalary = 9_000;*/


            //create obejct using constructor
           /* var emp2 = new Employee("131", "Kang", "Dian", "kang@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 10_000);
            var emp3 = new Employee("132", "Wini", "Widi", "wini@gmail.com", new DateTime(1999, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 11_000);
            var emp4 = new Employee("133", "Rini", "Mini", "rini@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 12_000);
            var emp5 = new Employee("134","Yuli", "Yuliana", "yuli@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 10_000);
           

            //call object programmer
            var emp6 = new Programmer("135","Asep", "Dudi","asep@gmail.com", new DateTime(1998, 1, 10), new DateTime(2020, 1, 10), Roles.PROGRAMMER, 10_000,5_000);
            emp6.BasicSalary = 15_000;

            //store object employee
            List<Employee> employees = new List<Employee>() { emp2, emp3, emp4, emp5, emp6 };

            //display employees
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }

            //call total salary
            Console.WriteLine($"Total Salary : {Employee.GetTotalSalary(employees)}");*/

        }
    }
}
