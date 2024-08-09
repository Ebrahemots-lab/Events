using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.Ex04
{
    public class Subscriber
    {
        public string? Name { get; set; }

        public void NotifySubscriber(Channel channel , Video video) 
        {
            Console.WriteLine($"Hello {Name} {channel.Name} Channel Has Uploaded A New Video\n Title : {video.Title}");

        }
    }
}
