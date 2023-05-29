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
            pictureBoxCrime = new PictureBox();

            textBoxMax = new TextBox();
            textBoxMin = new TextBox();
            tabPageRun = new TabPage();
            comboBoxCrime = new ComboBox();
            btnOpenCal = new Button();
            buttonCrime = new Button();
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
            PricesType = new TextBox();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Price3roomTxtBox = new TextBox();
            Price2roomTxtBox = new TextBox();
            Price1roomTxtBox = new TextBox();
            apartRegionComboBox = new ComboBox();
            apartYearComboBox = new ComboBox();
            tabPageCrime = new TabPage();
            labelD = new Label();
            labelC = new Label();
            labelB = new Label();
            labelA = new Label();
            tabControl1.SuspendLayout();
            tabPageRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPulse).BeginInit();
            tabPageTemp.SuspendLayout();
            tabPageHouses.SuspendLayout();
            tabPageCrime.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageRun);
            tabControl1.Controls.Add(tabPageTemp);
            tabControl1.Controls.Add(tabPageHouses);
            tabControl1.Controls.Add(tabPageCrime);
            tabControl1.Location = new Point(11, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(885, 443);
            tabControl1.TabIndex = 0;
            // 
            // tabPageRun
            // 
            tabPageRun.Controls.Add(btnOpenCal);
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
            tabPageRun.Location = new Point(4, 29);
            tabPageRun.Name = "tabPageRun";
            tabPageRun.Padding = new Padding(3);
            tabPageRun.Size = new Size(877, 410);
            tabPageRun.TabIndex = 0;
            tabPageRun.Text = "Пробежки";
            tabPageRun.UseVisualStyleBackColor = true;
            // 
            // btnOpenCal
            // 
            btnOpenCal.Location = new Point(487, 325);
            btnOpenCal.Name = "btnOpenCal";
            btnOpenCal.Size = new Size(384, 29);
            btnOpenCal.TabIndex = 7;
            btnOpenCal.Text = "Подробнее";
            btnOpenCal.UseVisualStyleBackColor = true;
            btnOpenCal.Click += btnOpenCal_Click;
            // 
            // labelDist
            // 
            labelDist.AutoSize = true;
            labelDist.Location = new Point(673, 280);
            labelDist.Name = "labelDist";
            labelDist.Size = new Size(113, 20);
            labelDist.TabIndex = 6;
            labelDist.Text = "Пройдено (км)";
            // 
            // labelTotDur
            // 
            labelTotDur.AutoSize = true;
            labelTotDur.Location = new Point(526, 235);
            labelTotDur.Name = "labelTotDur";
            labelTotDur.Size = new Size(159, 20);
            labelTotDur.TabIndex = 6;
            labelTotDur.Text = "Общая продолжит-ть";
            // 
            // labelAvDur
            // 
            labelAvDur.AutoSize = true;
            labelAvDur.Location = new Point(673, 187);
            labelAvDur.Name = "labelAvDur";
            labelAvDur.Size = new Size(170, 20);
            labelAvDur.TabIndex = 6;
            labelAvDur.Text = "Средняя продолжит-ть";
            // 
            // labelAvSpeed
            // 
            labelAvSpeed.AutoSize = true;
            labelAvSpeed.Location = new Point(737, 100);
            labelAvSpeed.Name = "labelAvSpeed";
            labelAvSpeed.Size = new Size(134, 20);
            labelAvSpeed.TabIndex = 6;
            labelAvSpeed.Text = "Средняя скорость";
            // 
            // labelMiSpeed
            // 
            labelMiSpeed.AutoSize = true;
            labelMiSpeed.Location = new Point(487, 100);
            labelMiSpeed.Name = "labelMiSpeed";
            labelMiSpeed.Size = new Size(175, 20);
            labelMiSpeed.TabIndex = 6;
            labelMiSpeed.Text = "Минимальная скорость";
            // 
            // labelMaSpeed
            // 
            labelMaSpeed.AutoSize = true;
            labelMaSpeed.Location = new Point(693, 12);
            labelMaSpeed.Name = "labelMaSpeed";
            labelMaSpeed.Size = new Size(179, 20);
            labelMaSpeed.TabIndex = 6;
            labelMaSpeed.Text = "Максимальная скорость";
            // 
            // labelAvPulse
            // 
            labelAvPulse.AutoSize = true;
            labelAvPulse.Location = new Point(487, 12);
            labelAvPulse.Name = "labelAvPulse";
            labelAvPulse.Size = new Size(113, 20);
            labelAvPulse.TabIndex = 6;
            labelAvPulse.Text = "Средний пульс";
            // 
            // textBoxDist
            // 
            textBoxDist.Location = new Point(487, 280);
            textBoxDist.Name = "textBoxDist";
            textBoxDist.Size = new Size(180, 27);
            textBoxDist.TabIndex = 5;
            // 
            // textBoxAvDur
            // 
            textBoxAvDur.Location = new Point(487, 187);
            textBoxAvDur.Name = "textBoxAvDur";
            textBoxAvDur.Size = new Size(180, 27);
            textBoxAvDur.TabIndex = 5;
            // 
            // textBoxDur
            // 
            textBoxDur.Location = new Point(691, 235);
            textBoxDur.Name = "textBoxDur";
            textBoxDur.Size = new Size(180, 27);
            textBoxDur.TabIndex = 5;
            // 
            // textBoxPulse
            // 
            textBoxPulse.Location = new Point(487, 43);
            textBoxPulse.Name = "textBoxPulse";
            textBoxPulse.Size = new Size(180, 27);
            textBoxPulse.TabIndex = 5;
            // 
            // textBoxAvSpeed
            // 
            textBoxAvSpeed.Location = new Point(691, 132);
            textBoxAvSpeed.Name = "textBoxAvSpeed";
            textBoxAvSpeed.Size = new Size(180, 27);
            textBoxAvSpeed.TabIndex = 5;
            // 
            // textBoxMaSpeed
            // 
            textBoxMaSpeed.Location = new Point(691, 43);
            textBoxMaSpeed.Name = "textBoxMaSpeed";
            textBoxMaSpeed.Size = new Size(180, 27);
            textBoxMaSpeed.TabIndex = 5;
            // 
            // textBoxMiSpeed
            // 
            textBoxMiSpeed.Location = new Point(487, 132);
            textBoxMiSpeed.Name = "textBoxMiSpeed";
            textBoxMiSpeed.Size = new Size(180, 27);
            textBoxMiSpeed.TabIndex = 5;
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(7, 163);
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
            pictureBoxMin.Location = new Point(7, 187);
            pictureBoxMin.Margin = new Padding(3, 4, 3, 4);
            pictureBoxMin.Name = "pictureBoxMin";
            pictureBoxMin.Size = new Size(474, 167);
            pictureBoxMin.TabIndex = 2;
            pictureBoxMin.TabStop = false;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(7, 361);
            buttonLoad.Margin = new Padding(3, 4, 3, 4);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(864, 41);
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
            pictureBoxPulse.Size = new Size(474, 116);
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
            tabPageTemp.Padding = new Padding(3);
            tabPageTemp.Size = new Size(877, 410);
            tabPageTemp.TabIndex = 1;
            tabPageTemp.Text = "Температура";
            tabPageTemp.UseVisualStyleBackColor = true;
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
            tabPageHouses.Controls.Add(PricesType);
            tabPageHouses.Controls.Add(button2);
            tabPageHouses.Controls.Add(label8);
            tabPageHouses.Controls.Add(label7);
            tabPageHouses.Controls.Add(label6);
            tabPageHouses.Controls.Add(label5);
            tabPageHouses.Controls.Add(label4);
            tabPageHouses.Controls.Add(Price3roomTxtBox);
            tabPageHouses.Controls.Add(Price2roomTxtBox);
            tabPageHouses.Controls.Add(Price1roomTxtBox);
            tabPageHouses.Controls.Add(apartRegionComboBox);
            tabPageHouses.Controls.Add(apartYearComboBox);
            tabPageHouses.Location = new Point(4, 29);
            tabPageHouses.Name = "tabPageHouses";
            tabPageHouses.Size = new Size(877, 410);
            tabPageHouses.TabIndex = 2;
            tabPageHouses.Text = "Жилье";
            tabPageHouses.UseVisualStyleBackColor = true;
            // 
            // PricesType
            // 
            PricesType.Location = new Point(350, 221);
            PricesType.Margin = new Padding(3, 4, 3, 4);
            PricesType.Name = "PricesType";
            PricesType.Size = new Size(507, 27);
            PricesType.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(350, 115);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(165, 80);
            button2.TabIndex = 10;
            button2.Text = "Построить график по региону за последние 15 лет";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 283);
            label8.Name = "label8";
            label8.Size = new Size(327, 20);
            label8.TabIndex = 9;
            label8.Text = "Средняя цена за кв.м. 3-комнатной квартиры";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 197);
            label7.Name = "label7";
            label7.Size = new Size(327, 20);
            label7.TabIndex = 8;
            label7.Text = "Средняя цена за кв.м. 2-комнатной квартиры";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 115);
            label6.Name = "label6";
            label6.Size = new Size(327, 20);
            label6.TabIndex = 7;
            label6.Text = "Средняя цена за кв.м. 1-комнатной квартиры";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 29);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 6;
            label5.Text = "Регион";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 29);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 5;
            label4.Text = "Год";
            // 
            // Price3roomTxtBox
            // 
            Price3roomTxtBox.Location = new Point(25, 307);
            Price3roomTxtBox.Margin = new Padding(3, 4, 3, 4);
            Price3roomTxtBox.Name = "Price3roomTxtBox";
            Price3roomTxtBox.Size = new Size(293, 27);
            Price3roomTxtBox.TabIndex = 4;
            // 
            // Price2roomTxtBox
            // 
            Price2roomTxtBox.Location = new Point(25, 221);
            Price2roomTxtBox.Margin = new Padding(3, 4, 3, 4);
            Price2roomTxtBox.Name = "Price2roomTxtBox";
            Price2roomTxtBox.Size = new Size(293, 27);
            Price2roomTxtBox.TabIndex = 3;
            // 
            // Price1roomTxtBox
            // 
            Price1roomTxtBox.Location = new Point(25, 139);
            Price1roomTxtBox.Margin = new Padding(3, 4, 3, 4);
            Price1roomTxtBox.Name = "Price1roomTxtBox";
            Price1roomTxtBox.Size = new Size(293, 27);
            Price1roomTxtBox.TabIndex = 2;
            // 
            // apartRegionComboBox
            // 
            apartRegionComboBox.FormattingEnabled = true;
            apartRegionComboBox.Location = new Point(210, 53);
            apartRegionComboBox.Margin = new Padding(3, 4, 3, 4);
            apartRegionComboBox.Name = "apartRegionComboBox";
            apartRegionComboBox.Size = new Size(303, 28);
            apartRegionComboBox.TabIndex = 1;
            apartRegionComboBox.SelectedIndexChanged += apartRegionComboBox_SelectedIndexChanged;
            // 
            // apartYearComboBox
            // 
            apartYearComboBox.FormattingEnabled = true;
            apartYearComboBox.Location = new Point(25, 53);
            apartYearComboBox.Margin = new Padding(3, 4, 3, 4);
            apartYearComboBox.Name = "apartYearComboBox";
            apartYearComboBox.Size = new Size(126, 28);
            apartYearComboBox.TabIndex = 0;
            apartYearComboBox.SelectedIndexChanged += apartYearComboBox_SelectedIndexChanged;
            // 
            // tabPageCrime
            // 
            tabPageCrime.Controls.Add(labelD); 
            tabPageCrime.Controls.Add(labelC);
            tabPageCrime.Controls.Add(labelB); 
            tabPageCrime.Controls.Add(labelA);
            tabPageCrime.Controls.Add(textBoxMax); 
            tabPageCrime.Controls.Add(textBoxMin);
            tabPageCrime.Controls.Add(pictureBoxCrime); 
            tabPageCrime.Controls.Add(comboBoxCrime);
            tabPageCrime.Controls.Add(buttonCrime); 
            tabPageCrime.Location = new Point(4, 24);
            tabPageCrime.Name = "tabPageCrime"; 
            tabPageCrime.Padding = new Padding(3);
            tabPageCrime.Size = new Size(766, 304); 
            tabPageCrime.TabIndex = 3;
            tabPageCrime.Text = " Преступность"; 
            tabPageCrime.UseVisualStyleBackColor = true;
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.Location = new Point(291, 262);
            labelD.Name = "labelD";
            labelD.Size = new Size(105, 20);
            labelD.TabIndex = 8;
            labelD.Text = "больше всего";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Location = new Point(24, 262);
            labelC.Name = "labelC";
            labelC.Size = new Size(17, 20);
            labelC.TabIndex = 7;
            labelC.Text = "а";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(379, 233);
            labelB.Name = "labelB";
            labelB.Size = new Size(187, 20);
            labelB.TabIndex = 6;
            labelB.Text = "меньше всего снизились,";
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(24, 233);
            labelA.Name = "labelA";
            labelA.Size = new Size(71, 20);
            labelA.TabIndex = 5;
            labelA.Text = "За 15 лет";
            textBoxMax.Location = new Point(40, 256); 
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(242, 23); 
            textBoxMax.TabIndex = 4;
            //             
            // textBoxMin
            //
            textBoxMin.Location = new Point(92, 227);
            textBoxMin.Name = "textBoxMin"; 
            textBoxMin.Size = new Size(269, 23);
            textBoxMin.TabIndex = 3;            
            // 
            // pictureBoxCrime            
            // 
            pictureBoxCrime.Location = new Point(21, 72); 
            pictureBoxCrime.Name = "pictureBoxCrime";
            pictureBoxCrime.Size = new Size(722, 144); 
            pictureBoxCrime.TabIndex = 2;
            pictureBoxCrime.TabStop = false;            
            // 
            // comboBoxCrime            
            // 
            comboBoxCrime.FormattingEnabled = true; 
            comboBoxCrime.Items.AddRange(new object[] { "убийства и покушение на убийство", 
                "умышленное причинение тяжкого вреда здоровью", "изнасилование и покушение на изнасилование", 
                "грабеж", "преступления, связанные с незаконным оборотом наркотиков" });
            comboBoxCrime.Location = new Point(50, 43); 
            comboBoxCrime.Name = "comboBoxCrime";
            comboBoxCrime.Size = new Size(311, 23); 
            comboBoxCrime.TabIndex = 1;
            comboBoxCrime.SelectedIndexChanged += comboBoxCrime_SelectedIndexChanged;            
            // 
            // buttonCrime            
            // 
            buttonCrime.Location = new Point(452, 42); 
            buttonCrime.Name = "buttonCrime";
            buttonCrime.Size = new Size(75, 23); 
            buttonCrime.TabIndex = 0;
            buttonCrime.Text = "Прочитать"; 
            buttonCrime.UseVisualStyleBackColor = true;
            buttonCrime.Click += buttonCrime_Click;
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
            Load += View_Load_1;
            tabControl1.ResumeLayout(false);
            tabPageRun.ResumeLayout(false);
            tabPageRun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPulse).EndInit();
            tabPageTemp.ResumeLayout(false);
            tabPageTemp.PerformLayout();
            tabPageHouses.ResumeLayout(false);
            tabPageHouses.PerformLayout();
            tabPageCrime.ResumeLayout(false);
            tabPageCrime.PerformLayout();
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
        private Button btnOpenCal;
        private ComboBox apartRegionComboBox;
        private ComboBox apartYearComboBox;
        private Label label4;
        private TextBox Price3roomTxtBox;
        private TextBox Price2roomTxtBox;
        private TextBox Price1roomTxtBox;
        private Button button2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox PricesType;
        private Label labelD;
        private Label labelC;
        private Label labelB;
        private Label labelA;
        private TextBox textBoxMax;
        private TextBox textBoxMin;
        private PictureBox pictureBoxCrime;
        private ComboBox comboBoxCrime;
        private Button buttonCrime;
    }
}