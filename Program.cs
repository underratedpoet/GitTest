using GitTestApp.Run;
using System.Text.Json;

namespace GitTestApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // отсюда удалить все нахер
            //Workout w1 = new Workout(new DateTime(2023, 4, 1), 30.45m, 4.1m, 20, 9, 31, 86);
            //string jsonString = JsonSerializer.Serialize<Workout>(w1);
            //Workout? w2 = JsonSerializer.Deserialize<Workout>(jsonString);


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new View());
        }
    }
}