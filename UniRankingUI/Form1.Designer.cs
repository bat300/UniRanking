namespace UniRankingUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.comboBoxUniversities = new System.Windows.Forms.ComboBox();
            this.comboBoxGrouping = new System.Windows.Forms.ComboBox();
            this.buttonAverageScores = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRatingForYear = new System.Windows.Forms.Button();
            this.buttonRatingForTheUni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016"});
            this.comboBoxYears.Location = new System.Drawing.Point(52, 25);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYears.TabIndex = 0;
            // 
            // comboBoxUniversities
            // 
            this.comboBoxUniversities.FormattingEnabled = true;
            this.comboBoxUniversities.Location = new System.Drawing.Point(352, 50);
            this.comboBoxUniversities.Name = "comboBoxUniversities";
            this.comboBoxUniversities.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUniversities.TabIndex = 1;
            // 
            // comboBoxGrouping
            // 
            this.comboBoxGrouping.FormattingEnabled = true;
            this.comboBoxGrouping.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxGrouping.Location = new System.Drawing.Point(148, 74);
            this.comboBoxGrouping.Name = "comboBoxGrouping";
            this.comboBoxGrouping.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGrouping.TabIndex = 2;
            // 
            // buttonAverageScores
            // 
            this.buttonAverageScores.Location = new System.Drawing.Point(623, 50);
            this.buttonAverageScores.Name = "buttonAverageScores";
            this.buttonAverageScores.Size = new System.Drawing.Size(103, 61);
            this.buttonAverageScores.TabIndex = 3;
            this.buttonAverageScores.Text = "Show minimum, maximum and average scores for for all Universities.";
            this.buttonAverageScores.UseVisualStyleBackColor = true;
            this.buttonAverageScores.Click += new System.EventHandler(this.buttonAverageScores_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 163);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(738, 238);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chose a year to see the World University Rating for it.";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Do you want this rating to be grouped by country?";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chose the University to see rating for it for every year.";
            // 
            // buttonRatingForYear
            // 
            this.buttonRatingForYear.Location = new System.Drawing.Point(38, 92);
            this.buttonRatingForYear.Name = "buttonRatingForYear";
            this.buttonRatingForYear.Size = new System.Drawing.Size(93, 46);
            this.buttonRatingForYear.TabIndex = 8;
            this.buttonRatingForYear.Text = "Show rating for the year.";
            this.buttonRatingForYear.UseVisualStyleBackColor = true;
            this.buttonRatingForYear.Click += new System.EventHandler(this.buttonRatingForYear_Click);
            // 
            // buttonRatingForTheUni
            // 
            this.buttonRatingForTheUni.Location = new System.Drawing.Point(352, 95);
            this.buttonRatingForTheUni.Name = "buttonRatingForTheUni";
            this.buttonRatingForTheUni.Size = new System.Drawing.Size(104, 43);
            this.buttonRatingForTheUni.TabIndex = 9;
            this.buttonRatingForTheUni.Text = "Show all ratings for the University.";
            this.buttonRatingForTheUni.UseVisualStyleBackColor = true;
            this.buttonRatingForTheUni.Click += new System.EventHandler(this.buttonRatingForTheUni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 422);
            this.Controls.Add(this.buttonRatingForTheUni);
            this.Controls.Add(this.buttonRatingForYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAverageScores);
            this.Controls.Add(this.comboBoxGrouping);
            this.Controls.Add(this.comboBoxUniversities);
            this.Controls.Add(this.comboBoxYears);
            this.Name = "Form1";
            this.Text = "Database for Universities Ranking.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxYears;
        private System.Windows.Forms.ComboBox comboBoxUniversities;
        private System.Windows.Forms.ComboBox comboBoxGrouping;
        private System.Windows.Forms.Button buttonAverageScores;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRatingForYear;
        private System.Windows.Forms.Button buttonRatingForTheUni;
    }
}

