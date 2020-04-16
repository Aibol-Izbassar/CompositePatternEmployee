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
            Operator op3 = new Operator();
            op3.Name = "Rinat";
            Operator op4 = new Operator();
            op4.Name = "Yla";
            Operator op5 = new Operator();
            op5.Name = "Mira";
            Operator op6 = new Operator();
            op6.Name = "Jack";

            Manager m1 = new Manager();
            m1.Name = "Bobby";
            Manager m2 = new Manager();
            m2.Name = "Tommy";

            Director d1 = new Director();

            m1.AddSubordinate(op1);
            m2.AddSubordinate(op2);


            Console.WriteLine("Попытка добавить к Оператору подчиненного");
            try
            {
                op1.AddSubordinate(op2);
            }
            catch (EmployeeException empl)
            {
                Console.WriteLine(empl.Message);
            }

            Console.WriteLine("Попытка добавить уже имеющигося подчиненного");
            try
            {
                m1.AddSubordinate(op1);
            }
            catch (EmployeeContains ec)
            {

                Console.WriteLine(ec.Message);
            }


            Console.WriteLine("Попытка добавить 6 подчиненных");
            try
            {
                m1.AddSubordinate(op2);
                m1.AddSubordinate(op3);
                m1.AddSubordinate(op4);
                m1.AddSubordinate(op5);
                m1.AddSubordinate(op6);
            }
            catch (EmployeeCounter ec)
            {
                Console.WriteLine(ec.Message);
            }

            d1.AddSubordinate(m1);
            var newManager = d1.UpSubbordinate(op1, m1);

            Console.WriteLine($"After UpSubbordinate Manager {m1.Name} employees count  {m1.Employees.Count()}");
            Console.WriteLine($"New manager: {newManager.Name}");
        }
    }
}
