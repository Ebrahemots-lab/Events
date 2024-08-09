using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.AssignmentEmployee
{
    public class Department
    {
        /*
         *  Employee should be removed from Department Staff List in both
            Cases
             If Employee Vacation Stock < 0
             If Employee Age > 60
         */

        public int DeptID { get; set; }

        public string DeptName { get; set; }

        List<Employee>? Staff = new List<Employee>();

        public void AddStaff(Employee E) 
        {
           if(E is not null) 
            {
                Staff.Add(E);

                E.EmployeeLayOff += RemoveStaff;
            }
        }

        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            //convert the sender to Employee
            Employee? employee = sender as Employee;

            if (employee != null)
            {
                Console.WriteLine($"Employee {employee.EmployeeID} Removed From {DeptName} Department Because of {e.Cause}");
                Staff.Remove(employee);
            }
        }

     
        public override string ToString()
        {
            string staff = "";
            Staff.ForEach(s => staff += $"\n{s}");
            return $"DeptID: {DeptID}\nDeptName: {DeptName}\nStaff: {staff}";
        }

        //public void StaffLoop() 
        //{
        //   for(int i = 0; i < Staff.Count; i++) {
        //        if (Staff[i].VacationStock < 0) 
        //        {
        //            RemoveStaff(Staff[i], new EmployeeLayOffEventArgs() { Cause = LayOffCause.VacationStockSmallerThanZero });
        //        }
        //        if(Helper.CalculateAgeInYears(Staff[i].BirthDate) > 60) 
        //        {
        //            RemoveStaff(Staff[i], new EmployeeLayOffEventArgs() { Cause = LayOffCause.EmployeeAgeLargerThan60});

        //        }
        //    }
        //}
    }
}
