using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.Ex01
{
    public struct Location
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }



        public static bool operator == (Location l , Location r) 
        {
            bool isValid = false;

            if (l.X == r.X && l.Y == r.Y && l.Z == r.Z)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
            
        }

        public static bool operator !=(Location l, Location r)
        {
            bool isValid = false;

            if (l.X == r.X && l.Y == r.Y && l.Z == r.Z)
            {
                isValid = false;
            }
            else 
            {
                isValid = true;
            }

            return isValid;

        }
    }
}
