using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1._2
{
    public class Room
    {
        static int RoomCounter;
        private int _roomNo = 0;
        private string _guest;
        private DateTime _checkIn;

        private Random rnd = new Random(System.Environment.TickCount);
        private ObservableCollection<String> names = new ObservableCollection<string>() { "Paul", "Karen", "Tomas", "Aisling", "Peter", "Katie", "Kieran", "Megan" };

        public int RoomNo { get { return _roomNo; } set { _roomNo = value; } }

        public string Guest { get { return _guest; } set { _guest = value; } }

        public DateTime CheckIn { get { return _checkIn; } set { _checkIn = value; } }

        public Room()
        {
            _roomNo = RoomCounter++;
            RoomNo = _roomNo + 1;

            int hasGuest = rnd.Next() % 2;
            if (hasGuest == 0)
            {
                Guest = names[rnd.Next(names.Count)];
                DateTime rndCheckIn = DateTime.Now;
                int aWeekInSecs = (int)new TimeSpan(7, 0, 0, 0).TotalSeconds;
                CheckIn = rndCheckIn.Subtract(new TimeSpan(0, 0, aWeekInSecs - rnd.Next(aWeekInSecs)));
            }
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(Guest))
            {
                return String.Format("ROOM: {0} (Vacant)", RoomNo);
            }
            else
                return String.Format("ROOM: {0} Guest: {1} Checked in : {2:dd/MM/yy H:mm:ss}", RoomNo, Guest, CheckIn);
        }
    }  // end class
}  // end ns