using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class EmployeeException:Exception
    {
        public override string Message => "Employee add exception";
    }
}
