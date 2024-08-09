using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.AssignmentEmployee
{
    public class Helper
    {
        public static string CauseConverter(LayOffCause cause)
        {
            string result = cause switch
            {
                LayOffCause.EmployeeAgeLargerThan60 => "Employee Age Larger Than 60",
                LayOffCause.VacationStockSmallerThanZero => "Employee VacationStock Smaller Than 0",
                _ => "Error.."
            } ;


            return result;
        }

        public static int CalculateAgeInYears(DateTime birthDate)
        {

            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now < birthDate.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }
}
