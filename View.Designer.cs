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
            label2 = new Label();
            label1 = new Label();
            pictureBoxMin = new PictureBox();
            button1 = new Button();
            pictureBoxPulse = new PictureBox();
            tabPageTemp = new TabPage();
            tabPageHouses = new TabPage();
            tabControl1.SuspendLayout();
            tabPageRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPulse).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageRun);
            tabControl1.Controls.Add(tabPageTemp);
            tabControl1.Controls.Add(tabPageHouses);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPageRun
            // 
            tabPageRun.Controls.Add(label2);
            tabPageRun.Controls.Add(label1);
            tabPageRun.Controls.Add(pictureBoxMin);
            tabPageRun.Controls.Add(button1);
            tabPageRun.Controls.Add(pictureBoxPulse);
            tabPageRun.Location = new Point(4, 29);
            tabPageRun.Name = "tabPageRun";
            tabPageRun.Padding = new Padding(3);
            tabPageRun.Size = new Size(768, 393);
            tabPageRun.TabIndex = 0;
            tabPageRun.Text = "Пробежки";
            tabPageRun.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 142);
            label2.Name = "label2";
            label2.Size = new Size(421, 20);
            label2.TabIndex = 4;
            label2.Text = "Изменения длительности тренировок за последний месяц";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(415, 20);
            label1.TabIndex = 3;
            label1.Text = "Изменения пульса во время занятий за последний месяц";
            // 
            // pictureBoxMin
            // 
            pictureBoxMin.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxMin.Location = new Point(6, 165);
            pictureBoxMin.Name = "pictureBoxMin";
            pictureBoxMin.Size = new Size(415, 177);
            pictureBoxMin.TabIndex = 2;
            pictureBoxMin.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(6, 348);
            button1.Name = "button1";
            button1.Size = new Size(756, 39);
            button1.TabIndex = 1;
            button1.Text = "Загрузить данные";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonLoad_Click;
            // 
            // pictureBoxPulse
            // 
            pictureBoxPulse.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxPulse.Location = new Point(6, 32);
            pictureBoxPulse.Name = "pictureBoxPulse";
            pictureBoxPulse.Size = new Size(415, 107);
            pictureBoxPulse.TabIndex = 0;
            pictureBoxPulse.TabStop = false;
            // 
            // tabPageTemp
            // 
            tabPageTemp.Location = new Point(4, 29);
            tabPageTemp.Name = "tabPageTemp";
            tabPageTemp.Padding = new Padding(3);
            tabPageTemp.Size = new Size(768, 393);
            tabPageTemp.TabIndex = 1;
            tabPageTemp.Text = "Температура";
            tabPageTemp.UseVisualStyleBackColor = true;
            // 
            // tabPageHouses
            // 
            tabPageHouses.Location = new Point(4, 29);
            tabPageHouses.Name = "tabPageHouses";
            tabPageHouses.Size = new Size(768, 393);
            tabPageHouses.TabIndex = 2;
            tabPageHouses.Text = "Жилье";
            tabPageHouses.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "View";
            Text = "App";
            Load += View_Load;
            tabControl1.ResumeLayout(false);
            tabPageRun.ResumeLayout(false);
            tabPageRun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPulse).EndInit();
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
    }
}