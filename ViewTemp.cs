using GitTestApp.Temp;
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
    public partial class ViewTemp : Form
    {
        Temperature temp = new Temperature();

        public ViewTemp()
        {
            InitializeComponent();
            temp.ReadFromFile(temp.Temps);
            temp.FoundDrop(richTextBox1, temp.Temps);
        }

        private void ViewTemp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();

            Point[] points = new Point[temp.Temps.Count];

            Pen MaxPen = new Pen(Color.Red, 1);
            for (int i = 0; i < temp.Temps.Count; i++)
            {
                points[i] = new Point(i * 25, -temp.Temps[i].MaxTemp * 5 + 125);
            }
            graphics.DrawLines(MaxPen, points);

            Pen MinPen = new Pen(Color.Blue, 1);
            for (int i = 0; i < 30; i++)
            {
                points[i] = new Point(i * 25, -temp.Temps[i].MinTemp * 5 + 125);
            }
            graphics.DrawLines(MinPen, points);

            Pen AvgPen = new Pen(Color.Gray, 1);
            for (int i = 0; i < 30; i++)
            {
                points[i] = new Point(i * 25, -temp.Temps[i].AvgTemp * 5 + 125);
            }
            graphics.DrawLines(AvgPen, points);
        }
    }
}
