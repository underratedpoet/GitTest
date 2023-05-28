using GitTestApp.Run;
using OxyPlot;
using OxyPlot.Series;

using GitTestApp.Temp;
using GitTestApp.RusCrime;

namespace GitTestApp
{
    public partial class View : Form
    {
        Temperature temp = new Temperature();


        public View()
        {
            InitializeComponent();
            temp.ReadFromFile(temp.Temps);
        }
        private void tabPageTemp_Click(object sender, EventArgs e)
        {

        }

        private void buttonTemp(object sender, EventArgs e)
        {
            ViewTemp Temp = new ViewTemp();
            Temp.Show();
        }

        private void monthCalendarDateChanged(object sender, DateRangeEventArgs e)
        {
            string Date = monthCalendar1.SelectionStart.ToShortDateString();
            temp.SearchTemp(temp.Temps, textBox1, textBox2, textBox3, Date);

        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            WorkoutFacade.UploadInfo("Run\\workout_info.json");

            List<Workout> wkts = new List<Workout>();
            WorkoutFacade.Workouts.ForEach(workout => { wkts.Add(workout); });

            //while (wkts.Count % 3 != 1) wkts.Add(wkts[wkts.Count - 1]);

            Graphics graphics = pictureBoxPulse.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3f);

            Point[] points = new Point[wkts.Count()];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i * 36, -3 * (int)wkts[i].AvgPulse + 320);
            }

            graphics.DrawLines(pen, points);

            Graphics g = pictureBoxMin.CreateGraphics();

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i * 36, -4 * (int)wkts[i].Duration + 210);
            }

            g.DrawLines(pen, points);

            textBoxAvDur.Text = Math.Round(WorkoutFacade.AvgDuration, 2).ToString();
            textBoxAvSpeed.Text = WorkoutFacade.AvgSpeed.ToString();
            textBoxDist.Text = WorkoutFacade.TotalDistance.ToString();
            textBoxMaSpeed.Text = WorkoutFacade.MaxSpeed.ToString();
            textBoxMiSpeed.Text = WorkoutFacade.MinSpeed.ToString();
            textBoxPulse.Text = WorkoutFacade.AvgPulse.ToString();
            textBoxDur.Text = WorkoutFacade.TotalDuration.ToString();
        }

        private void btnOpenCal_Click(object sender, EventArgs e)
        {
            ViewWorkout workout = new ViewWorkout();
            workout.Show();
        }

        private void buttonCrime_Click(object sender, EventArgs e)
        {
            Crime crime = new Crime();
            List<Crime> list = new List<Crime>();
            crime.ReadfromFile(list);

            crime.Difference(textBoxMin, textBoxMax, list[0].Crimes, list);

        }

        private void comboBoxCrime_SelectedIndexChanged(object sender, EventArgs e)
        {
            Crime crime = new Crime();
            List<Crime> list = new List<Crime>();

            crime.ReadfromFile(list);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == comboBoxCrime.SelectedIndex)
                {
                    list[i].Crimes.Count();
                    crime.PaintGraphic(pictureBoxCrime, list[i].Crimes, list[i].Id);
                }
            }

        }
    }
}