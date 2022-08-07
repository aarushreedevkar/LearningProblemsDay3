using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public static class PartTimeEmployeeWage
    {
        public static void PartTimeWage()
        {
            int PRESENT = 1;
            int Full_TIME = 1;
            int PART_TIME = 2;
            int EMP_RATE_PER_HR = 20;

            //local variables
            int empHrs = 0;
            int empwage = 0;
            int empWage = 0;

            //inbuilt class
            Random random = new Random();
            int employeeCheck = random.Next(0, 3);

        
            //selection statements

           // if (employeeCheck == PRESENT)
                if (employeeCheck == Full_TIME)
                {
                    empHrs = 8;
                }
                else
                 if (employeeCheck == PART_TIME)
                {
                    empHrs = 4;
                }
                else
                {
                    empHrs = 0;
                }
            //computation
            empwage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("emp wage per day " + empwage);
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Emp wage per day " + empWage);
            
        }
    }
}


