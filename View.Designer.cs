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
            labelDist = new Label();
            labelTotDur = new Label();
            labelAvDur = new Label();
            labelAvSpeed = new Label();
            labelMiSpeed = new Label();
            labelMaSpeed = new Label();
            labelAvPulse = new Label();
            textBoxDist = new TextBox();
            textBoxAvDur = new TextBox();
            textBoxDur = new TextBox();
            textBoxPulse = new TextBox();
            textBoxAvSpeed = new TextBox();
            textBoxMaSpeed = new TextBox();
            textBoxMiSpeed = new TextBox();
            labelMin = new Label();
            labelPulse = new Label();
            pictureBoxMin = new PictureBox();
            buttonLoad = new Button();
            pictureBoxPulse = new PictureBox();
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
            tabPageCrime = new TabPage();
            tabControl1.SuspendLayout();
            tabPageRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPulse).BeginInit();
            tabPageTemp.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageRun);
            tabControl1.Controls.Add(tabPageTemp);
            tabControl1.Controls.Add(tabPageHouses);
            tabControl1.Controls.Add(tabPageCrime);
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(774, 332);
            tabControl1.TabIndex = 0;
            // 
            // tabPageRun
            // 
            tabPageRun.Controls.Add(labelDist);
            tabPageRun.Controls.Add(labelTotDur);
            tabPageRun.Controls.Add(labelAvDur);
            tabPageRun.Controls.Add(labelAvSpeed);
            tabPageRun.Controls.Add(labelMiSpeed);
            tabPageRun.Controls.Add(labelMaSpeed);
            tabPageRun.Controls.Add(labelAvPulse);
            tabPageRun.Controls.Add(textBoxDist);
            tabPageRun.Controls.Add(textBoxAvDur);
            tabPageRun.Controls.Add(textBoxDur);
            tabPageRun.Controls.Add(textBoxPulse);
            tabPageRun.Controls.Add(textBoxAvSpeed);
            tabPageRun.Controls.Add(textBoxMaSpeed);
            tabPageRun.Controls.Add(textBoxMiSpeed);
            tabPageRun.Controls.Add(labelMin);
            tabPageRun.Controls.Add(labelPulse);
            tabPageRun.Controls.Add(pictureBoxMin);
            tabPageRun.Controls.Add(buttonLoad);
            tabPageRun.Controls.Add(pictureBoxPulse);
            tabPageRun.Location = new Point(4, 24);
            tabPageRun.Margin = new Padding(3, 2, 3, 2);
            tabPageRun.Name = "tabPageRun";
            tabPageRun.Padding = new Padding(3, 2, 3, 2);
            tabPageRun.Size = new Size(766, 304);
            tabPageRun.TabIndex = 0;
            tabPageRun.Text = "Пробежки";
            tabPageRun.UseVisualStyleBackColor = true;
            // 
            // labelDist
            // 
            labelDist.AutoSize = true;
            labelDist.Location = new Point(589, 244);
            labelDist.Name = "labelDist";
            labelDist.Size = new Size(89, 15);
            labelDist.TabIndex = 6;
            labelDist.Text = "Пройдено (км)";
            // 
            // labelTotDur
            // 
            labelTotDur.AutoSize = true;
            labelTotDur.Location = new Point(460, 213);
            labelTotDur.Name = "labelTotDur";
            labelTotDur.Size = new Size(127, 15);
            labelTotDur.TabIndex = 6;
            labelTotDur.Text = "Общая продолжит-ть";
            // 
            // labelAvDur
            // 
            labelAvDur.AutoSize = true;
            labelAvDur.Location = new Point(589, 178);
            labelAvDur.Name = "labelAvDur";
            labelAvDur.Size = new Size(134, 15);
            labelAvDur.TabIndex = 6;
            labelAvDur.Text = "Средняя продолжит-ть";
            // 
            // labelAvSpeed
            // 
            labelAvSpeed.AutoSize = true;
            labelAvSpeed.Location = new Point(645, 75);
            labelAvSpeed.Name = "labelAvSpeed";
            labelAvSpeed.Size = new Size(106, 15);
            labelAvSpeed.TabIndex = 6;
            labelAvSpeed.Text = "Средняя скорость";
            // 
            // labelMiSpeed
            // 
            labelMiSpeed.AutoSize = true;
            labelMiSpeed.Location = new Point(426, 75);
            labelMiSpeed.Name = "labelMiSpeed";
            labelMiSpeed.Size = new Size(139, 15);
            labelMiSpeed.TabIndex = 6;
            labelMiSpeed.Text = "Минимальная скорость";
            // 
            // labelMaSpeed
            // 
            labelMaSpeed.AutoSize = true;
            labelMaSpeed.Location = new Point(606, 9);
            labelMaSpeed.Name = "labelMaSpeed";
            labelMaSpeed.Size = new Size(143, 15);
            labelMaSpeed.TabIndex = 6;
            labelMaSpeed.Text = "Максимальная скорость";
            // 
            // labelAvPulse
            // 
            labelAvPulse.AutoSize = true;
            labelAvPulse.Location = new Point(426, 9);
            labelAvPulse.Name = "labelAvPulse";
            labelAvPulse.Size = new Size(90, 15);
            labelAvPulse.TabIndex = 6;
            labelAvPulse.Text = "Средний пульс";
            // 
            // textBoxDist
            // 
            textBoxDist.Location = new Point(426, 244);
            textBoxDist.Margin = new Padding(3, 2, 3, 2);
            textBoxDist.Name = "textBoxDist";
            textBoxDist.Size = new Size(158, 23);
            textBoxDist.TabIndex = 5;
            // 
            // textBoxAvDur
            // 
            textBoxAvDur.Location = new Point(426, 178);
            textBoxAvDur.Margin = new Padding(3, 2, 3, 2);
            textBoxAvDur.Name = "textBoxAvDur";
            textBoxAvDur.Size = new Size(158, 23);
            textBoxAvDur.TabIndex = 5;
            // 
            // textBoxDur
            // 
            textBoxDur.Location = new Point(605, 213);
            textBoxDur.Margin = new Padding(3, 2, 3, 2);
            textBoxDur.Name = "textBoxDur";
            textBoxDur.Size = new Size(158, 23);
            textBoxDur.TabIndex = 5;
            // 
            // textBoxPulse
            // 
            textBoxPulse.Location = new Point(426, 32);
            textBoxPulse.Margin = new Padding(3, 2, 3, 2);
            textBoxPulse.Name = "textBoxPulse";
            textBoxPulse.Size = new Size(158, 23);
            textBoxPulse.TabIndex = 5;
            // 
            // textBoxAvSpeed
            // 
            textBoxAvSpeed.Location = new Point(605, 99);
            textBoxAvSpeed.Margin = new Padding(3, 2, 3, 2);
            textBoxAvSpeed.Name = "textBoxAvSpeed";
            textBoxAvSpeed.Size = new Size(158, 23);
            textBoxAvSpeed.TabIndex = 5;
            // 
            // textBoxMaSpeed
            // 
            textBoxMaSpeed.Location = new Point(605, 32);
            textBoxMaSpeed.Margin = new Padding(3, 2, 3, 2);
            textBoxMaSpeed.Name = "textBoxMaSpeed";
            textBoxMaSpeed.Size = new Size(158, 23);
            textBoxMaSpeed.TabIndex = 5;
            // 
            // textBoxMiSpeed
            // 
            textBoxMiSpeed.Location = new Point(426, 99);
            textBoxMiSpeed.Margin = new Padding(3, 2, 3, 2);
            textBoxMiSpeed.Name = "textBoxMiSpeed";
            textBoxMiSpeed.Size = new Size(158, 23);
            textBoxMiSpeed.TabIndex = 5;
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(6, 122);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(330, 15);
            labelMin.TabIndex = 4;
            labelMin.Text = "Изменения длительности тренировок за последний месяц";
            // 
            // labelPulse
            // 
            labelPulse.AutoSize = true;
            labelPulse.Location = new Point(6, 9);
            labelPulse.Name = "labelPulse";
            labelPulse.Size = new Size(323, 15);
            labelPulse.TabIndex = 3;
            labelPulse.Text = "Изменения пульса во время занятий за последний месяц";
            // 
            // pictureBoxMin
            // 
            pictureBoxMin.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxMin.Location = new Point(6, 140);
            pictureBoxMin.Name = "pictureBoxMin";
            pictureBoxMin.Size = new Size(415, 126);
            pictureBoxMin.TabIndex = 2;
            pictureBoxMin.TabStop = false;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(6, 271);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(756, 31);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Загрузить данные";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // pictureBoxPulse
            // 
            pictureBoxPulse.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxPulse.Location = new Point(6, 32);
            pictureBoxPulse.Name = "pictureBoxPulse";
            pictureBoxPulse.Size = new Size(415, 88);
            pictureBoxPulse.TabIndex = 0;
            pictureBoxPulse.TabStop = false;
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
            tabPageTemp.Size = new Size(766, 304);
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
            tabPageHouses.Size = new Size(766, 304);
            tabPageHouses.TabIndex = 2;
            tabPageHouses.Text = "Жилье";
            tabPageHouses.UseVisualStyleBackColor = true;
            // 
            // tabPageCrime
            // 
            tabPageCrime.Location = new Point(4, 24);
            tabPageCrime.Name = "tabPageCrime";
            tabPageCrime.Padding = new Padding(3);
            tabPageCrime.Size = new Size(766, 304);
            tabPageCrime.TabIndex = 3;
            tabPageCrime.Text = " Преступность";
            tabPageCrime.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 341);
            Controls.Add(tabControl1);
            Name = "View";
            Text = "App";
            Load += View_Load;
            tabControl1.ResumeLayout(false);
            tabPageRun.ResumeLayout(false);
            tabPageRun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPulse).EndInit();
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
        private PictureBox pictureBoxPulse;
        private PictureBox pictureBoxMin;
        private Label label2;
        private Label label1;
        private Button buttonLoad;
        private Label label3;
        private Label labelMin;
        private Label labelPulse;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
        private TextBox textBoxDist;
        private TextBox textBoxAvDur;
        private TextBox textBoxDur;
        private TextBox textBoxPulse;
        private TextBox textBoxAvSpeed;
        private TextBox textBoxMaSpeed;
        private TextBox textBoxMiSpeed;
        private Label labelDist;
        private Label labelTotDur;
        private Label labelAvDur;
        private Label labelAvSpeed;
        private Label labelMiSpeed;
        private Label labelMaSpeed;
        private Label labelAvPulse;
        private TabPage tabPageCrime;
    }
}