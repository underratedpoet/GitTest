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
            tabControl1.Location = new Point(11, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(885, 442);
            tabControl1.TabIndex = 0;
            // 
            // tabPageRun
            // 
            tabPageRun.Controls.Add(labelMin);
            tabPageRun.Controls.Add(labelPulse);
            tabPageRun.Controls.Add(pictureBoxMin);
            tabPageRun.Controls.Add(buttonLoad);
            tabPageRun.Controls.Add(pictureBoxPulse);
            tabPageRun.Location = new Point(4, 29);
            tabPageRun.Name = "tabPageRun";
            tabPageRun.Padding = new Padding(3, 3, 3, 3);
            tabPageRun.Size = new Size(877, 409);
            tabPageRun.TabIndex = 0;
            tabPageRun.Text = "Пробежки";
            tabPageRun.UseVisualStyleBackColor = true;
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(7, 189);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(421, 20);
            labelMin.TabIndex = 4;
            labelMin.Text = "Изменения длительности тренировок за последний месяц";
            // 
            // labelPulse
            // 
            labelPulse.AutoSize = true;
            labelPulse.Location = new Point(7, 12);
            labelPulse.Name = "labelPulse";
            labelPulse.Size = new Size(415, 20);
            labelPulse.TabIndex = 3;
            labelPulse.Text = "Изменения пульса во время занятий за последний месяц";
            // 
            // pictureBoxMin
            // 
            pictureBoxMin.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxMin.Location = new Point(7, 213);
            pictureBoxMin.Margin = new Padding(3, 4, 3, 4);
            pictureBoxMin.Name = "pictureBoxMin";
            pictureBoxMin.Size = new Size(474, 129);
            pictureBoxMin.TabIndex = 2;
            pictureBoxMin.TabStop = false;
            // 
            // buttonUpload
            // 
            buttonLoad.Location = new Point(7, 350);
            buttonLoad.Margin = new Padding(3, 4, 3, 4);
            buttonLoad.Name = "buttonUpload";
            buttonLoad.Size = new Size(864, 52);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Загрузить данные";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // pictureBoxPulse
            // 
            pictureBoxPulse.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxPulse.Location = new Point(7, 43);
            pictureBoxPulse.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPulse.Name = "pictureBoxPulse";
            pictureBoxPulse.Size = new Size(474, 141);
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
            tabPageTemp.Location = new Point(4, 29);
            tabPageTemp.Name = "tabPageTemp";
            tabPageTemp.Padding = new Padding(3, 3, 3, 3);
            tabPageTemp.Size = new Size(877, 409);
            tabPageTemp.TabIndex = 1;
            tabPageTemp.Text = "Температура";
            tabPageTemp.UseVisualStyleBackColor = true;
            tabPageTemp.Click += tabPageTemp_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(47, 49);
            monthCalendar1.Margin = new Padding(10, 12, 10, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            monthCalendar1.DateChanged += monthCalendarDateChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 205);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 8;
            label3.Text = "Минимальная";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 140);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 7;
            label2.Text = "Средняя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 72);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 6;
            label1.Text = "Максимальная";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(456, 201);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(456, 136);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(456, 68);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(603, 332);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(137, 28);
            button1.TabIndex = 1;
            button1.Text = "Показать график";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonTemp;
            // 
            // tabPageHouses
            // 
            tabPageHouses.Location = new Point(4, 29);
            tabPageHouses.Name = "tabPageHouses";
            tabPageHouses.Size = new Size(768, 473);
            tabPageHouses.TabIndex = 2;
            tabPageHouses.Text = "Жилье";
            tabPageHouses.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 455);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}