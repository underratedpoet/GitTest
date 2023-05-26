using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GitTestApp.Run
{
    internal static class WorkoutFacade
    {
        static WorkoutFacade()
        {
            Workouts = new List<Workout> { new Workout() };
            _lastMonth = DateTime.Now.AddMonths(-1);
            TotalDuration = 0;
            TotalDistance = 0;
            MinSpeed = uint.MaxValue;
            MaxSpeed = 0;
        }

        public static List<Workout> Workouts;

        private static DateTime _lastMonth;

        public static decimal TotalDistance { get; private set; }
        public static decimal TotalDuration { get; private set; }
        public static decimal AvgDuration { get; private set; }

        public static uint AvgSpeed { get; private set; }
        public static uint MinSpeed { get; private set; }
        public static uint MaxSpeed { get; private set; }
        public static uint AvgPulse { get; private set; }

        public static void UploadInfo(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException("not found");

            string jsonString = File.ReadAllText(filePath);

            List<Workout>? workouts = JsonSerializer.Deserialize<List<Workout>>(jsonString);

            if (workouts == null) throw new ArgumentNullException(nameof(workouts));

            Workouts = workouts;

            DeleteWrong();

            FindValues();
        }

        private static void DeleteWrong()
        {
            List<int> indexes = new List<int>();

            for (int i = 0; i < Workouts.Count(); i++)
            {
                if (Workouts[i].Date < _lastMonth ||
                    Workouts[i].Date > DateTime.Today)
                { 
                    Workouts.Remove(Workouts[i]);
                    i--;
                }
            }


        }

        private static void FindValues()
        {
            uint count = 0;
            uint pulsSum = 0;
            uint speedSum = 0;
            TotalDuration = 0;
            TotalDistance = 0;
            MinSpeed = uint.MaxValue;
            MaxSpeed = 0;

            foreach (Workout workout in Workouts)
            {
                if (workout.MinSpeed < MinSpeed) MinSpeed = workout.MinSpeed;
                if (workout.MaxSpeed > MaxSpeed) MaxSpeed = workout.MaxSpeed;

                speedSum += workout.AvgSpeed;
                pulsSum += workout.AvgPulse;

                TotalDistance += workout.Distance;
                TotalDuration += workout.Duration;

                count++;
            }

            AvgDuration = TotalDuration / count;
            AvgPulse = pulsSum / count;
            AvgSpeed = speedSum / count;
        }
    }
}
