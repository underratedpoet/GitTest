using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestApp.Run
{
    internal class Workout
    {
        public Workout()
        {
            Date = DateTime.Now;
            Duration = 1;
            Distance = 1;
            AvgSpeed = 1;
            MinSpeed = 1;
            MaxSpeed = 1;
            AvgPulse = 80;
        }

        public Workout(DateTime date, decimal duration, decimal distance, uint avgSpeed, 
            uint minSpeed, uint maxSpeed, uint avgPulse)
        {
            Date = date;
            Duration = duration;
            Distance = distance;
            Distance = distance;
            AvgSpeed = avgSpeed;
            MinSpeed = minSpeed;
            MaxSpeed = maxSpeed;
            AvgPulse = avgPulse;
        }

        private DateTime _date;
        public string? Weekday { get; private set; }

        public DateTime Date 
        { 
            get 
            {
                return _date;
            } 
            set 
            {
                _date = value;
                Weekday = value.ToString("dddd");
            } 
        }

        private decimal _duration;
        public decimal Duration 
        {
            get { return _duration; }
            set { if (value <= 0) throw new ArgumentException("value");
            _duration = value;}
        }

        private decimal _distance;
        public decimal Distance
        {
            get { return _distance; }
            set
            {
                if (value <= 0) throw new ArgumentException("value");
                _distance = value;
            }
        }

        public uint AvgSpeed { get; set; }
        public uint MinSpeed { get; set; }
        public uint MaxSpeed { get; set; }
        public uint AvgPulse { get; set; }


    }
}
