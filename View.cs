using GitTestApp.Temp;

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
    }
}