using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Room
    {
        private int _roomNo;
        private string _guest;
        private DateTime _checkIn;

        private Random rnd = new Random(System.Environment.TickCount);

        private List<String> names = new List<string>() { "Paul", "Karen", "Tomas", "Katie", "Peter", "Megan", "Aisling", "Kieran" };

        public int RoomNo { get { return _roomNo; } set { _roomNo = value; } }
        public string Guest { get { return _guest; } set { _guest = value; } }
        public DateTime CheckIn { get { return _checkIn; } set { _checkIn = value; } }

        public Room(int rmNo)
        {
            RoomNo = rmNo;

            int hasGuest = rnd.Next() % 2;
            if (hasGuest == 0)
            {
                Guest = names[rnd.Next(names.Count)];
                //DateTime rndCheckIn = DateTime.Now.Subtract(new TimeSpan(rnd.Next(7),rnd.Next(24),rnd.Next(60),rnd.Next(60)));
                DateTime rndCheckIn = DateTime.Now;
                int aWeekInSeconds = (int)new TimeSpan(7, 0, 0, 0).TotalSeconds;
                CheckIn = rndCheckIn.Subtract(new TimeSpan(0, 0, aWeekInSeconds - rnd.Next(aWeekInSeconds)));
            }
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(Guest))
                return String.Format("[{0}] (Vacant)", RoomNo);
            else
                return String.Format("[{0}] Guest: {1} checked in at: {2:dd/MM/yy H:mm:ss}", RoomNo, Guest, CheckIn);
        }
    }  // end class
}  //end ns
