using GitTestApp.Run;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTestApp
{
    public partial class ViewWorkout : Form
    {
        public ViewWorkout()
        {
            InitializeComponent();
        }

        private void ViewWorkout_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Workout? workout = WorkoutFacade.FindWorkout(monthCalendar1.SelectionStart.ToShortDateString());
            if (workout == null)
            {
                textBoxCalDis.Text = "Нет данных";
                textBoxCalDur.Text = "Нет данных";
                textBoxCalPul.Text = "Нет данных";
                textBoxCalSp.Text = "Нет данных";
                return;
            }
            textBoxCalDis.Text = workout.Distance.ToString();
            textBoxCalDur.Text = workout.Duration.ToString();
            textBoxCalPul.Text = workout.AvgPulse.ToString();
            textBoxCalSp.Text = workout.AvgSpeed.ToString();
        }
    }
}
