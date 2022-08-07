using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public static class EmployeePresentAbsent
    {
        public static void EmployeePresentOrAbsent()

        {

            int present = 0;
            Random random = new Random(); //Inbuilt class Random
            int employeecheck = random.Next(0, 2);
            if (employeecheck == present)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");

        }
    }

}
