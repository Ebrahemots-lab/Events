using EventsLib.Ex02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.AssignmentEmployee
{
    public class Club
    {
        //         Employee should be removed from Club Member List Only if Employee
        //Vacation Stock< 0.
        // If Employee Age> 60 will still remain a Member of Company Club


        public int ClubID { get; set; }

        public string? ClubName { get; set; }

        List<Employee>? Members = new List<Employee>();

        public void AddMember(Employee E) 
        {
          if(E is not null) 
            {
                Members.Add(E);

                E.EmployeeLayOff += RemoveMember;
            }
        }

        public void RemoveMember(object sender , EmployeeLayOffEventArgs e) 
        {
            Employee Employee = sender as Employee;

            if(e.Cause == LayOffCause.VacationStockSmallerThanZero) 
            {
                Console.WriteLine($"Employee {Employee.EmployeeID} Removed From {ClubName} Club Because of {e.Cause}");

                Members.Remove(Employee);
            }
        }


        public override string ToString()
        {
            string result = "";
            foreach(Employee emp in Members) 
            {
                result += $"ClubId: {ClubID}\n ClubName: {ClubName} \n Member {emp.EmployeeID} :: BirthDate: {emp.BirthDate} :: VacationStock: {emp.VacationStock}\n"; 
            }
            Console.WriteLine();
            return result;
        }

    }

}
