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

        public uint AvgSpeed;
        public uint MinSpeed;
        public uint MaxSpeed;
        public uint AvgPulse;


    }
}
