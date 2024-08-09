using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.AssignmentEmployee
{
    public class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;  

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e) 
        {

            EmployeeLayOff?.Invoke(this, e);
            
        }

        public int EmployeeID { get; set; }

        public DateTime BirthDate { get; set; }

        private int vacationStock;

        public int VacationStock
        {
            get { return vacationStock; }
            set 
            {
                if(value < 0) 
                {
                    
                }
                else 
                {
                    vacationStock = value;
                }
            }
        }



        //Create constructor 
        public Employee(int id , DateTime birthDate , int vacation)
        {
            EmployeeID = id;
            BirthDate = birthDate;
            vacationStock = vacation;
        }


        public bool RequestVacation(DateTime From , DateTime To) 
        {
            if (From > To)
                Console.WriteLine("Invalid Stock");
            if (VacationStock >= (To - From).Days)
            {
                VacationStock -= (To - From).Days;
                return true;
            }
            return false;
        }

        public void LayOffEmp()
        {
            if(Helper.CalculateAgeInYears(BirthDate) > 60) 
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.EmployeeAgeLargerThan60});
                return;
            }
            if(vacationStock < 0) 
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.VacationStockSmallerThanZero});
                return;
            }    
        }
        public void EndOfYearOperation() 
        {
            //increase vacation stock at every Year
            VacationStock += 5;
        }

        public override string ToString()
        {
            return $"Employee {EmployeeID} :: BirthDate: {BirthDate} :: VacationStock: {vacationStock}";
        }



    }
}
