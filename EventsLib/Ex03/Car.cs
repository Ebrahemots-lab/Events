using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.Ex03
{
    public class Car
    {

        public void Move(Colors color) 
        {
            switch (color)
            {
                case Colors.Green:
                    Console.WriteLine("Move It's Green..");
                 break;
                case Colors.Red:
                    Console.WriteLine("Don't Move it's Red");
                    break;
                case Colors.Yellow:
                    Console.WriteLine("Prepare it will be Green soon");
                    break;
            }
        }
    }
}
