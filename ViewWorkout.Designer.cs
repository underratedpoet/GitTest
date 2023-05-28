namespace GitTestApp
{
    partial class ViewWorkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthCalendar1 = new MonthCalendar();
            textBoxCalDur = new TextBox();
            textBoxCalDis = new TextBox();
            textBoxCalSp = new TextBox();
            textBoxCalPul = new TextBox();
            labelCalDur = new Label();
            labelCalDis = new Label();
            labelCarAvSp = new Label();
            labelCalPul = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // textBoxCalDur
            // 
            textBoxCalDur.Location = new Point(461, 18);
            textBoxCalDur.Name = "textBoxCalDur";
            textBoxCalDur.ReadOnly = true;
            textBoxCalDur.Size = new Size(125, 27);
            textBoxCalDur.TabIndex = 1;
            // 
            // textBoxCalDis
            // 
            textBoxCalDis.Location = new Point(461, 79);
            textBoxCalDis.Name = "textBoxCalDis";
            textBoxCalDis.ReadOnly = true;
            textBoxCalDis.Size = new Size(125, 27);
            textBoxCalDis.TabIndex = 1;
            // 
            // textBoxCalSp
            // 
            textBoxCalSp.Location = new Point(461, 137);
            textBoxCalSp.Name = "textBoxCalSp";
            textBoxCalSp.ReadOnly = true;
            textBoxCalSp.Size = new Size(125, 27);
            textBoxCalSp.TabIndex = 1;
            // 
            // textBoxCalPul
            // 
            textBoxCalPul.Location = new Point(461, 198);
            textBoxCalPul.Name = "textBoxCalPul";
            textBoxCalPul.ReadOnly = true;
            textBoxCalPul.Size = new Size(125, 27);
            textBoxCalPul.TabIndex = 1;
            // 
            // labelCalDur
            // 
            labelCalDur.AutoSize = true;
            labelCalDur.Location = new Point(267, 18);
            labelCalDur.Name = "labelCalDur";
            labelCalDur.Size = new Size(188, 20);
            labelCalDur.TabIndex = 2;
            labelCalDur.Text = "Продолжительность, мин";
            // 
            // labelCalDis
            // 
            labelCalDis.AutoSize = true;
            labelCalDis.Location = new Point(342, 79);
            labelCalDis.Name = "labelCalDis";
            labelCalDis.Size = new Size(113, 20);
            labelCalDis.TabIndex = 2;
            labelCalDis.Text = "Расстояние, км";
            // 
            // labelCarAvSp
            // 
            labelCarAvSp.AutoSize = true;
            labelCarAvSp.Location = new Point(282, 137);
            labelCarAvSp.Name = "labelCarAvSp";
            labelCarAvSp.Size = new Size(173, 20);
            labelCarAvSp.TabIndex = 2;
            labelCarAvSp.Text = "Средняя скорость, км/ч";
            // 
            // labelCalPul
            // 
            labelCalPul.AutoSize = true;
            labelCalPul.Location = new Point(342, 198);
            labelCalPul.Name = "labelCalPul";
            labelCalPul.Size = new Size(113, 20);
            labelCalPul.TabIndex = 2;
            labelCalPul.Text = "Средний пульс";
            // 
            // ViewWorkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 245);
            Controls.Add(labelCalPul);
            Controls.Add(labelCarAvSp);
            Controls.Add(labelCalDis);
            Controls.Add(labelCalDur);
            Controls.Add(textBoxCalPul);
            Controls.Add(textBoxCalSp);
            Controls.Add(textBoxCalDis);
            Controls.Add(textBoxCalDur);
            Controls.Add(monthCalendar1);
            Name = "ViewWorkout";
            Text = "Workout calendar";
            Load += ViewWorkout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TextBox textBoxCalDur;
        private TextBox textBoxCalDis;
        private TextBox textBoxCalSp;
        private TextBox textBoxCalPul;
        private Label labelCalDur;
        private Label labelCalDis;
        private Label labelCarAvSp;
        private Label labelCalPul;
    }
}