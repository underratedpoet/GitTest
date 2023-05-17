using System;
using System.Collections.Generic;
using System.Linq;
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

            string jsonString = File.ReadAllText(filePath);

            List<Workout>? workouts = JsonSerializer.Deserialize<List<Workout>>(jsonString);

            if (workouts == null) throw new ArgumentNullException(nameof(workouts));

            Workouts = workouts;
        }
    }
}
