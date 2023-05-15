using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestApp.Run
{
    internal static class WorkoutFacade
    {
        static WorkoutFacade()
        {
            Workouts = new List<Workout> { new Workout() };
        }

        public static List<Workout> Workouts;

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



        }
    }
}
