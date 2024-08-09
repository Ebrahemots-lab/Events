using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.AssignmentEmployee
{
    public class SalesPerson : Employee
    {
        public SalesPerson(int id, DateTime birthDate, int vacation) : base(id, birthDate, vacation)
        {
        }

        public int AchievedTarget { get; set; }

        public bool CheckTarget(int Quota) 
        {
     
            return AchievedTarget >= Quota;
        }

        public void FireSalesPerson() 
        {

            if (!CheckTarget(100)) 
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.TargetNotAchived });
            }
        }
    }
}
