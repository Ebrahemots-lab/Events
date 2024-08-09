using EventsLib;
using EventsLib.Ex01;
using EventsLib.Ex02;
using EventsLib.Ex03;
using EventsLib.Ex04;
using System.Collections;
namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Event : it's a way that a class notify another class that something Happend

            #region Ex 01
            //Ball x = new Ball() { Location = new Location() { X = 1, Y = 1, Z = 1 } };

            //Console.WriteLine("Match Start in 3 Seconds");
            //Thread.Sleep(3000);

            //Player p1 = new Player() { Name = "Ebrahem" };
            //Player p2 = new Player() { Name = "Ashraf" };

            //Refee ref1 = new Refee() {Name = "Alhebashy"};

            //x.BallMoved += p1.Run;
            //x.BallMoved += p2.Run;
            //x.BallMoved += ref1.Look;

            //x.Location = new Location() { X = 1, Y = 3, Z = 1 }; 
            #endregion

            #region Ex02
            /*
             * we need to make an alarm Clock that notify all students 
             * that the time is 7PM and they must leave the work
             */


            //AlarmClock clock = new AlarmClock();

            //Employee employee = new Employee() { Id = 1};
            //Employee employee02 = new Employee() { Id = 2 };
            //Employee employee03 = new Employee() { Id = 3 };

            //Manger manger = new Manger() { Name = "Ebrahem"};


            ////Subsribe to the event 
            //clock.WorkDone += employee.LeaveWork;
            //clock.WorkDone += employee02.LeaveWork;
            //clock.WorkDone += employee03.LeaveWork;

            //Console.WriteLine("All Emps Has Leaving the Work");

            //clock.WorkDone += manger.LeaveWork;

            //clock.On7PM();


            #endregion

            #region Ex03
            //TrafficLight traffic = new TrafficLight();
            //Car c1 = new Car();


            //traffic.ColorChanged += c1.Move;


            //traffic.AllowMoving(Colors.Red);

            //Thread.Sleep(3000);

            //traffic.AllowMoving(Colors.Yellow);

            //Thread.Sleep(3000);

            //traffic.AllowMoving(Colors.Green);



            #endregion

            #region Ex04
            //Channel movies = new Channel() { Name = "Movies24Hour"};

            //Subscriber sub01 = new Subscriber() { Name = "Ebrahem" };
            //Subscriber sub02 = new Subscriber() { Name = "Ashraf" };
            //Subscriber sub03 = new Subscriber() { Name = "Ahmed" };
            //Subscriber sub04 = new Subscriber() { Name = "Abdelfatah" };
            //Subscriber sub05 = new Subscriber() { Name = "Alhebashy" };

            //movies.AddSubscriber(sub01);
            //movies.AddSubscriber(sub02);
            //movies.AddSubscriber(sub03);
            //movies.AddSubscriber(sub04);


            //Video video01 = new Video() { Title = "Beauiful and Best" };
            //Video video02 = new Video() { Title = "Assissian Creed" };
            //Video video03 = new Video() { Title = "GoodZilla and Kong" };


            //movies.UploadVideo(video01);

            //movies.UploadVideo(video02);

            //movies.UploadVideo(video03);





            #endregion

            #region HashTable
            //Hashtable table = new Hashtable();
            //table[1] = "Ebrahem";
            //table[2] = 1; 

            Hashtable hashtable = new Hashtable();
            //Adding Values
            hashtable.Add(1, "Ebrahem");
            hashtable.Add(2, "Ashraf");
            hashtable.Add(3, "Ahmed");

            Console.WriteLine(hashtable[1]);

            #endregion

            #region Dictionary
            Dictionary<string, int> example = new Dictionary<string, int> {
                      { "Apple", 1 },
                      { "Banana", 2 },
                      { "Cherry", 3 }
};


            Dictionary<string, int> phonebook = new Dictionary<string, int>();
            phonebook.Add("Ebrahem", 123456789);
            phonebook.Add("Ashraf", 1234);
            #endregion


        }

    }
}
