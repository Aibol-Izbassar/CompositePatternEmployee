using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Manager:Employee
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Manager()
        {

        }

        public override void AddSubordinate(Employee employee)
        {
            Employees.Add(employee);
        }

        public override void RemoveSubordinate(Employee employee)
        {
            Employees.Remove(employee);
        }

    }
}
