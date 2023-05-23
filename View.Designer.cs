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
            tabPageHouses = new TabPage();
            tabControl1.SuspendLayout();
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
            tabPageRun.Location = new Point(4, 29);
            tabPageRun.Name = "tabPageRun";
            tabPageRun.Padding = new Padding(3);
            tabPageRun.Size = new Size(768, 393);
            tabPageRun.TabIndex = 0;
            tabPageRun.Text = "Пробежки";
            tabPageRun.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageRun;
        private TabPage tabPageTemp;
        private TabPage tabPageHouses;
    }
}