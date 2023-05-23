using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestApp.Temp
{
    public class Temperature
    {
        public DateTime Date { get; set; }
        public int MaxTemp { get; set; }
        public int MinTemp { get; set; }
        public int AvgTemp { get; set; }

        public List<Temperature> Temps = new List<Temperature>();

        public Temperature() { }

        public Temperature(DateTime date, int maxTemp, int avgTemp, int minTemp) 
        {
            Date = date;
            MaxTemp = maxTemp;
            MinTemp = minTemp;
            AvgTemp = avgTemp;
        }

        public void ReadFromFile(List<Temperature> temps)
        {
            StreamReader reader = new StreamReader("c:/Users/Admin/Desktop/Temperature.txt");

            DateTime date;
            int maxTemp; 
            int avgTemp; 
            int minTemp;
            bool EndFile = false;

            while (EndFile != true)
            {
                date = DateTime.Parse(reader.ReadLine());
                maxTemp = Convert.ToInt32(reader.ReadLine());
                avgTemp = Convert.ToInt32(reader.ReadLine());
                minTemp = Convert.ToInt32(reader.ReadLine());
                EndFile = reader.EndOfStream;
                temps.Add(new Temperature(date, maxTemp, avgTemp, minTemp));
                
            }
            
        }

        public void SearchTemp (List<Temperature> temps, TextBox box1, TextBox box2, TextBox box3, string dateTemp)
        {
            string date;
            for (int i = 0; i < temps.Count; i++) 
            {
                date = temps[i].Date.ToShortDateString();
                if (date == dateTemp)
                {
                    box1.Text = temps[i].MaxTemp + " ";
                    box2.Text = temps[i].AvgTemp + " ";
                    box3.Text = temps[i].MinTemp + " ";
                }
            }
        }

        public void FoundDrop (RichTextBox box, List<Temperature> temps)
        {
            int drop;
            int maxDrop = 0;
            string date;
            int k = 0;
            for (int i = 0; i < temps.Count; i++)
            {
                drop = temps[i].MaxTemp - temps[i].MinTemp;
                if (drop > maxDrop)
                {
                    maxDrop = drop;
                    k = i;
                }
            }
            date = temps[k].Date.ToShortDateString();
            box.Text = String.Format("{0}, и составлял {1} градусов", date, maxDrop);
        }

    }
}
