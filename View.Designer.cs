namespace GitTestApp
{
    partial class View
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageRun = new TabPage();
            tabPageTemp = new TabPage();
            monthCalendar1 = new MonthCalendar();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            tabPageHouses = new TabPage();
            tabControl1.SuspendLayout();
            tabPageTemp.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageRun);
            tabControl1.Controls.Add(tabPageTemp);
            tabControl1.Controls.Add(tabPageHouses);
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(679, 320);
            tabControl1.TabIndex = 0;
            // 
            // tabPageRun
            // 
            tabPageRun.Location = new Point(4, 24);
            tabPageRun.Margin = new Padding(3, 2, 3, 2);
            tabPageRun.Name = "tabPageRun";
            tabPageRun.Padding = new Padding(3, 2, 3, 2);
            tabPageRun.Size = new Size(671, 292);
            tabPageRun.TabIndex = 0;
            tabPageRun.Text = "Пробежки";
            tabPageRun.UseVisualStyleBackColor = true;
            // 
            // tabPageTemp
            // 
            tabPageTemp.Controls.Add(monthCalendar1);
            tabPageTemp.Controls.Add(label3);
            tabPageTemp.Controls.Add(label2);
            tabPageTemp.Controls.Add(label1);
            tabPageTemp.Controls.Add(textBox3);
            tabPageTemp.Controls.Add(textBox2);
            tabPageTemp.Controls.Add(textBox1);
            tabPageTemp.Controls.Add(button1);
            tabPageTemp.Location = new Point(4, 24);
            tabPageTemp.Margin = new Padding(3, 2, 3, 2);
            tabPageTemp.Name = "tabPageTemp";
            tabPageTemp.Padding = new Padding(3, 2, 3, 2);
            tabPageTemp.Size = new Size(671, 292);
            tabPageTemp.TabIndex = 1;
            tabPageTemp.Text = "Температура";
            tabPageTemp.UseVisualStyleBackColor = true;
            tabPageTemp.Click += tabPageTemp_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(41, 37);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            monthCalendar1.DateChanged += monthCalendarDateChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 154);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 8;
            label3.Text = "Минимальная";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 105);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "Средняя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 54);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 6;
            label1.Text = "Максимальная";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(399, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(399, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(399, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(528, 249);
            button1.Name = "button1";
            button1.Size = new Size(120, 21);
            button1.TabIndex = 1;
            button1.Text = "Показать график";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonTemp;
            // 
            // tabPageHouses
            // 
            tabPageHouses.Location = new Point(4, 24);
            tabPageHouses.Margin = new Padding(3, 2, 3, 2);
            tabPageHouses.Name = "tabPageHouses";
            tabPageHouses.Size = new Size(671, 292);
            tabPageHouses.TabIndex = 2;
            tabPageHouses.Text = "Жилье";
            tabPageHouses.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "View";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPageTemp.ResumeLayout(false);
            tabPageTemp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageRun;
        private TabPage tabPageTemp;
        private TabPage tabPageHouses;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
    }
}