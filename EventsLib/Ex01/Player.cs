using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.Ex01
{
    public class Player
    {
        public string? Name { get; set; }

        public void Run() 
        {
            Console.WriteLine($"{Name} is Running Towards The Ball..");
        }
    }
}
