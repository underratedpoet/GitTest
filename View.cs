using GitTestApp.Run;
using OxyPlot;
using OxyPlot.Series;

namespace GitTestApp
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
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
                points[i] = new Point(i * 28, -3 * (int)wkts[i].AvgPulse + 320);
            }

            graphics.DrawLines(pen, points);

            Graphics g = pictureBoxMin.CreateGraphics();

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i * 28, -5 * (int)wkts[i].Duration + 210);
            }

            g.DrawLines(pen, points);


        }
    }
}