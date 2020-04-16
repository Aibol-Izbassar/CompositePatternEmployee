using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Operator:Employee
    {
        

        public override void AddSubordinate(Employee employee)
        {
            throw new EmployeeException();
        }

        public override void RemoveSubordinate(Employee employee)
        {
            throw new EmployeeException();
        }
    }
}
