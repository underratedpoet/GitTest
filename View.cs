using GitTestApp.Run;
using OxyPlot;
using OxyPlot.Series;

using GitTestApp.Temp;
using GitTestApp.Apartments;


namespace GitTestApp
{
    public partial class View : Form
    {
        Temperature temp = new Temperature();
        List<Apartment> aparts = new List<Apartment>();

        public View()
        {
            InitializeComponent();
            temp.ReadFromFile(temp.Temps);
            aparts = Apartment.ReadFromFile();
            Lists list = new Lists();
            apartYearComboBox.Items.AddRange(list.Years);
            apartRegionComboBox.Items.AddRange(list.RegionsList);
            double pr1r, pr2r, pr3r;
            Apartment.FindPrices(aparts, -1, -1, out pr1r, out pr2r, out pr3r);
            Price1roomTxtBox.Text = pr1r+""; Price2roomTxtBox.Text = pr2r + ""; Price3roomTxtBox.Text = pr3r + "";
            Apartment.SetPricesType(PricesType, aparts, 0);
        }
        private void tabPageTemp_Click(object sender, EventArgs e)
        {

        }

        /*private void tabPageHouses_Click(object sender, EventArgs e)
        {
            double pr1r, pr2r, pr3r;
            Apartment.FindPrices(aparts, -1, -1, out pr1r, out pr2r, out pr3r);
            Price1roomTxtBox.Text = pr1r+""; Price2roomTxtBox.Text = pr2r + ""; Price3roomTxtBox.Text = pr3r + "";
        }*/

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

        private void apartYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            double pr1r, pr2r, pr3r;
            Apartment.FindPrices(aparts, apartYearComboBox.SelectedIndex, apartRegionComboBox.SelectedIndex, out pr1r, out pr2r, out pr3r);
            Price1roomTxtBox.Text = pr1r + ""; Price2roomTxtBox.Text = pr2r + ""; Price3roomTxtBox.Text = pr3r + "";
            Apartment.SetPricesType(PricesType, aparts, apartRegionComboBox.SelectedIndex);
        }

        private void apartRegionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            double pr1r, pr2r, pr3r;
            Apartment.FindPrices(aparts, apartYearComboBox.SelectedIndex, apartRegionComboBox.SelectedIndex, out pr1r, out pr2r, out pr3r);
            Price1roomTxtBox.Text = pr1r + ""; Price2roomTxtBox.Text = pr2r + ""; Price3roomTxtBox.Text = pr3r + "";
            Apartment.SetPricesType(PricesType, aparts, apartRegionComboBox.SelectedIndex);
        }
    }
}