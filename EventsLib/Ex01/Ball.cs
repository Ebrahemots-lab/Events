using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.Ex01
{
    public class Ball
    {

		//Declare the delegate 
		public delegate void OnBallMoving();

		//Declare the event 
		public event OnBallMoving? BallMoved;

		private Location location;

		public Location Location
		{
			get { return location; }
			set 
			{ 
				if(value != location) 
				{
                    location = value;
                    BallMoved?.Invoke();
                }

            }
		}



	}
}
