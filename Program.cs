using System;
using System.Collections;
using System.Linq;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Operator op1 = new Operator();
            op1.Name = "Aibol";
            Operator op2 = new Operator();
            op2.Name = "Maks";

            Manager m1 = new Manager();
            m1.Name = "Bobby";
            Manager m2 = new Manager();
            m2.Name = "Tommy";

            try
            {
                op1.AddSubordinate(op2);
            }
            catch (EmployeeException empl)
            {
                Console.WriteLine(empl.Message);
            }

            m1.AddSubordinate(op1);
            m2.AddSubordinate(op2);

        }
    }
}
