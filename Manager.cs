using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Manager:Employee
    {
        int count = 0;
        public List<Employee> Employees { get; set; } = new List<Employee>();

        

        public override void AddSubordinate(Employee employee)
        {
            if (Employees.Count < 5)
            {
                if (Employees.Contains(employee))
                {
                    throw new EmployeeContains();
                }
                else
                    Employees.Add(employee);
            }
            else
                throw new EmployeeCounter();
        }

        public override void RemoveSubordinate(Employee employee)
        {
            if (Employees.Contains(employee))
            {
                Employees.Remove(employee);
            }
            else
                throw new EmployeeRemove();
            
        }

    }
}
