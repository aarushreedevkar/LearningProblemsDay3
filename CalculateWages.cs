using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public static class CalculateWages
    {

        public static void calculateHrswages()
        {


            const int Full_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS_MONTH = 10;

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int hrs = 0;
            int WorkingDays = 0;


            //inbuilt class
            Random random = new Random();
            int employeeCheck = random.Next(0, 3);


            while (hrs < MAX_WORKING_HRS_MONTH && WorkingDays <= MAX_WORKING_DAYS)
            {
                WorkingDays++;

                switch (employeeCheck)
                {
                    case Full_TIME:
                        empHrs = 8;
                        break;

                    case PART_TIME:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                hrs += empHrs;

                //computation
                empWage = EMP_RATE_PER_HR * empHrs;
                // hrs = empHrs;
                totalEmpWage = totalEmpWage + empWage;
                //totalEmpWage=totalWage+empWage


             Console.WriteLine("Emp wage for " + WorkingDays + "days" + totalEmpWage);
                Console.WriteLine("Working hrs " + hrs);

            }
        }
    }
}

       
