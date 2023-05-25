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

            temp.TempGraphic(pictureBox1, temp.Temps);
        }

        private void ViewTemp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            temp.TempGraphic(pictureBox1, temp.Temps);

        }
    }
}
