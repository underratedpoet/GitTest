using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestApp.RusCrime
{
    public class Crime
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<double> Crimes = new List<double>();
        public const int N = 15;

        public Crime() { }

        public Crime(int id, string name, List<double> crimes)
        {
            Name = name;
            Id = id;
            Crimes = crimes;
        }

        public void ReadfromFile(List<Crime> names)
        {

            StreamReader reader = new StreamReader("RusCrime/Crime.txt", Encoding.UTF8);

            string name;
            int id;
            List<double> crimes = new List<double>();
            bool EndFile = false;

            while (EndFile != true)
            {
                id = Convert.ToInt32(reader.ReadLine());
                name = reader.ReadLine();
                for (int i = 0; i < N; i++)
                {
                    crimes.Add(Convert.ToDouble(reader.ReadLine()));
                }
                names.Add(new Crime(id, name, crimes));
                EndFile = reader.EndOfStream;

            }
        }

        public void PaintGraphic(PictureBox box, List<double> crimes, int id)
        {
            Graphics graphics = box.CreateGraphics();
            graphics.Clear(Color.White);

            Point[] points = new Point[N];

            Pen pen = new Pen(Color.Black, 3f);
            for (int i = 0; i < N; i++)
            {
                points[i] = new Point(i * 50, Convert.ToInt32(crimes[i + 15 * id]));
            }
            graphics.DrawLines(pen, points);
        }

        public void Difference(TextBox minBox, TextBox maxBox, List<double> crimes, List<Crime> names)
        {
            int prob;
            int max = 0;
            int min = 100;
            for (int i = 0; i < crimes.Count; i += 15)
            {
                prob = Convert.ToInt32(crimes[i] - crimes[i + 14]);
                if (prob < min && prob > 0)
                {
                    min = prob;
                    minBox.Text = names[i / 15].Name;
                }
                if (prob > max)
                {
                    max = prob;
                    maxBox.Text = names[i / 15].Name;
                }
            }
        }

    }
}
