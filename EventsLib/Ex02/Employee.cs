using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.Ex02
{
    public class Employee : ILeavingWork
    {
        public int Id { get; set; }

        public void LeaveWork() 
        {
            Console.WriteLine($"Employee Number {Id} is Leaving the Work Now");
            Thread.Sleep(2000);
        }
    }
}
