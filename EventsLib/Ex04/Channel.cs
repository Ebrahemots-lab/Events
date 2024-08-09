using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib.Ex04
{
    public class Channel
    {
        public delegate void UploadingNewVideo(Channel channel , Video video);

        public event UploadingNewVideo? VideoUploaded;
        public string? Name { get; set; }

        List<Video> videos = new List<Video>();

        List<Subscriber> subscribers = new List<Subscriber>();

        //Method the add Subscribers
        public void AddSubscriber(Subscriber subscriber) 
        {
            subscribers.Add(subscriber);

            AddSubscribersToEvent(subscriber);
        }

        public void UploadVideo(Video video) 
        {
            //this method will add a new video to videos list then notify the subscribers that a new video uploaded
            videos.Add(video);

            Console.WriteLine($"Video {video.Title} Uploaded Sucssesfuly");

            Notify(this, video);

        }

        public void Notify(Channel channel , Video video) 
        {
            foreach(Subscriber subscriber in subscribers) 
            {
                subscriber.NotifySubscriber(channel,video);
            }
            Console.WriteLine("============");
        }

        public void AddSubscribersToEvent(Subscriber subscriber) 
        {
            VideoUploaded += subscriber.NotifySubscriber;
        }


    }
}
