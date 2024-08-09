using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.Ex02
{
    public class AlarmClock
    {
        public event Action? WorkDone;

        public void On7PM() 
        {
            Console.WriteLine("Time Now is 7PM");

            WorkDone?.Invoke();
        }
    }
}
