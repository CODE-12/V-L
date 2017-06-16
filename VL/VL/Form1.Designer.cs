namespace VL
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.D = new System.Windows.Forms.TextBox();
            this.T = new System.Windows.Forms.TextBox();
            this.Mood = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1160, 640);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(111)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.D);
            this.panel1.Controls.Add(this.T);
            this.panel1.Controls.Add(this.Mood);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.F);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 640);
            this.panel1.TabIndex = 1;
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.D.Location = new System.Drawing.Point(47, 92);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(100, 22);
            this.D.TabIndex = 7;
            // 
            // T
            // 
            this.T.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.T.Location = new System.Drawing.Point(47, 120);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(100, 22);
            this.T.TabIndex = 6;
            // 
            // Mood
            // 
            this.Mood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.Mood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Mood.Location = new System.Drawing.Point(47, 148);
            this.Mood.Name = "Mood";
            this.Mood.Size = new System.Drawing.Size(100, 22);
            this.Mood.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.button1.Location = new System.Drawing.Point(20, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "ارسم ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // F
            // 
            this.F.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.F.Location = new System.Drawing.Point(47, 64);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(100, 22);
            this.F.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.TextBox T;
        private System.Windows.Forms.TextBox Mood;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox F;
    }
}

