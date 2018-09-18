namespace VL
{
    partial class Start
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
            this.lesson = new MetroFramework.Controls.MetroComboBox();
            this.experiment = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lesson
            // 
            this.lesson.FormattingEnabled = true;
            this.lesson.ItemHeight = 23;
            this.lesson.Location = new System.Drawing.Point(129, 115);
            this.lesson.Name = "lesson";
            this.lesson.Size = new System.Drawing.Size(269, 29);
            this.lesson.TabIndex = 0;
            this.lesson.SelectedIndexChanged += new System.EventHandler(this.lesson_SelectedIndexChanged);
            // 
            // experiment
            // 
            this.experiment.FormattingEnabled = true;
            this.experiment.ItemHeight = 23;
            this.experiment.Location = new System.Drawing.Point(129, 216);
            this.experiment.Name = "experiment";
            this.experiment.Size = new System.Drawing.Size(269, 29);
            this.experiment.TabIndex = 1;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(150, 317);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(233, 49);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "ابدا";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(312, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "أختر الدرس";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(312, 174);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "اختر التجربة";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.experiment);
            this.Controls.Add(this.lesson);
            this.Name = "Start";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.Startcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox lesson;
        private MetroFramework.Controls.MetroComboBox experiment;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}