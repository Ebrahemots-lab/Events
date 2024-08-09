using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.Ex02
{
    public class Manger : ILeavingWork
    {
        public string Name { get; set; }

        public void LeaveWork()
        {
            Console.WriteLine($"Manger{Name} All Emps Leaved The Work");
        }
    }
}
