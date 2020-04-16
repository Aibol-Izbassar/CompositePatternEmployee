using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class EmployeeException:Exception
    {
        public override string Message => "Employee add exception";
    }
    class EmployeeCounter : Exception
    {
        public override string Message => "You have 5 employees, please UpSubbordinate with Director";
    }

    class EmployeeContains : Exception 
    {
        public override string Message => "You also have this employee";
    }
    class EmployeeRemove : Exception
    {
        public override string Message => "You can not remove this employee";
    }

}
