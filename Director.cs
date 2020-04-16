using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Director : Employee
    {
        List<Employee> Employees = new List<Employee>();
        public override void AddSubordinate(Employee employee)
        {
            Employees.Add(employee);
        }

        public override void RemoveSubordinate(Employee employee)
        {
            Employees.Add(employee);
        }

        public Manager UpSubbordinate(Employee employee, Manager man)
        {
            Manager manager = new Manager();
            manager.Name = employee.Name;
            man.RemoveSubordinate(employee);
            return manager;
        }
    }
}
