using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    abstract class Employee
    {
        public string Name { get; set; }
        public abstract void AddSubordinate(Employee employee);
        public abstract void RemoveSubordinate(Employee employee);


    }
}
