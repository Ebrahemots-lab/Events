using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.Ex01
{
    public class Refee
    {
        public string? Name { get; set; }

        public void Look() 
        {
            Console.WriteLine($"Refee {Name} is Looking To the Ball");
        }
    }
}
