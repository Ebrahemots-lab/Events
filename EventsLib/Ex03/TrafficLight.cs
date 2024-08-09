using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.Ex03
{
     public delegate void TrafficLightColors(Colors color);
    public class TrafficLight
    {
        
        //Declare the Delgate

        //Declare the events
        public event TrafficLightColors ColorChanged;

        public Colors Colors { get; set; }

        public void AllowMoving(Colors color) 
        {
            ColorChanged.Invoke(color);
        }
    }



    public enum Colors
    {
        Red,
        Green,
        Yellow,
    }
}
