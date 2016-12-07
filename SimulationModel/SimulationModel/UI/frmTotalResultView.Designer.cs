namespace SimulationModel.UI
{
    partial class frmTotalResultView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTotalResultView));
            this.lbl_AvgWaitTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_AvgWaitCust = new System.Windows.Forms.Label();
            this.lbl_ProbaWaitCust = new System.Windows.Forms.Label();
            this.lbl_IdleFrac = new System.Windows.Forms.Label();
            this.lbl_ServerBusy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_avgServTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_avgTimeBetwArrival = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_avgSpends = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_avgWaitThoseWho = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_AvgWaitTime
            // 
            this.lbl_AvgWaitTime.AutoSize = true;
            this.lbl_AvgWaitTime.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_AvgWaitTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AvgWaitTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AvgWaitTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_AvgWaitTime.Location = new System.Drawing.Point(117, 71);
            this.lbl_AvgWaitTime.Name = "lbl_AvgWaitTime";
            this.lbl_AvgWaitTime.Size = new System.Drawing.Size(319, 22);
            this.lbl_AvgWaitTime.TabIndex = 3;
            this.lbl_AvgWaitTime.Text = "Average Waiting Time for a Customer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(119, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "The Probability that a customer has to wait :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(119, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "The fraction of Idle Time of the server :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(119, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "The Probability of the Server being busy :";
            // 
            // lbl_AvgWaitCust
            // 
            this.lbl_AvgWaitCust.AutoSize = true;
            this.lbl_AvgWaitCust.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AvgWaitCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AvgWaitCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_AvgWaitCust.Location = new System.Drawing.Point(553, 71);
            this.lbl_AvgWaitCust.Name = "lbl_AvgWaitCust";
            this.lbl_AvgWaitCust.Size = new System.Drawing.Size(60, 24);
            this.lbl_AvgWaitCust.TabIndex = 7;
            this.lbl_AvgWaitCust.Text = "label4";
            // 
            // lbl_ProbaWaitCust
            // 
            this.lbl_ProbaWaitCust.AutoSize = true;
            this.lbl_ProbaWaitCust.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ProbaWaitCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProbaWaitCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ProbaWaitCust.Location = new System.Drawing.Point(553, 110);
            this.lbl_ProbaWaitCust.Name = "lbl_ProbaWaitCust";
            this.lbl_ProbaWaitCust.Size = new System.Drawing.Size(60, 24);
            this.lbl_ProbaWaitCust.TabIndex = 8;
            this.lbl_ProbaWaitCust.Text = "label5";
            // 
            // lbl_IdleFrac
            // 
            this.lbl_IdleFrac.AutoSize = true;
            this.lbl_IdleFrac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IdleFrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdleFrac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_IdleFrac.Location = new System.Drawing.Point(553, 151);
            this.lbl_IdleFrac.Name = "lbl_IdleFrac";
            this.lbl_IdleFrac.Size = new System.Drawing.Size(60, 24);
            this.lbl_IdleFrac.TabIndex = 9;
            this.lbl_IdleFrac.Text = "label6";
            // 
            // lbl_ServerBusy
            // 
            this.lbl_ServerBusy.AutoSize = true;
            this.lbl_ServerBusy.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ServerBusy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServerBusy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ServerBusy.Location = new System.Drawing.Point(553, 197);
            this.lbl_ServerBusy.Name = "lbl_ServerBusy";
            this.lbl_ServerBusy.Size = new System.Drawing.Size(60, 24);
            this.lbl_ServerBusy.TabIndex = 10;
            this.lbl_ServerBusy.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(119, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "The average Service Time :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_avgServTime
            // 
            this.lbl_avgServTime.AutoSize = true;
            this.lbl_avgServTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_avgServTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avgServTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_avgServTime.Location = new System.Drawing.Point(553, 243);
            this.lbl_avgServTime.Name = "lbl_avgServTime";
            this.lbl_avgServTime.Size = new System.Drawing.Size(60, 24);
            this.lbl_avgServTime.TabIndex = 12;
            this.lbl_avgServTime.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(119, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "The average Time between arrival :";
            // 
            // lbl_avgTimeBetwArrival
            // 
            this.lbl_avgTimeBetwArrival.AutoSize = true;
            this.lbl_avgTimeBetwArrival.BackColor = System.Drawing.Color.Transparent;
            this.lbl_avgTimeBetwArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avgTimeBetwArrival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_avgTimeBetwArrival.Location = new System.Drawing.Point(553, 287);
            this.lbl_avgTimeBetwArrival.Name = "lbl_avgTimeBetwArrival";
            this.lbl_avgTimeBetwArrival.Size = new System.Drawing.Size(60, 24);
            this.lbl_avgTimeBetwArrival.TabIndex = 14;
            this.lbl_avgTimeBetwArrival.Text = "label7";
            this.lbl_avgTimeBetwArrival.Click += new System.EventHandler(this.lbl_avgTimeBetwArrival_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(117, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(427, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "The average time a customer spends in the system :";
            // 
            // lbl_avgSpends
            // 
            this.lbl_avgSpends.AutoSize = true;
            this.lbl_avgSpends.BackColor = System.Drawing.Color.Transparent;
            this.lbl_avgSpends.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avgSpends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_avgSpends.Location = new System.Drawing.Point(553, 373);
            this.lbl_avgSpends.Name = "lbl_avgSpends";
            this.lbl_avgSpends.Size = new System.Drawing.Size(60, 24);
            this.lbl_avgSpends.TabIndex = 16;
            this.lbl_avgSpends.Text = "label9";
            this.lbl_avgSpends.Click += new System.EventHandler(this.lbl_avgSpends_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(119, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "The average waiting time of those who wait :";
            // 
            // lbl_avgWaitThoseWho
            // 
            this.lbl_avgWaitThoseWho.AutoSize = true;
            this.lbl_avgWaitThoseWho.BackColor = System.Drawing.Color.Transparent;
            this.lbl_avgWaitThoseWho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avgWaitThoseWho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_avgWaitThoseWho.Location = new System.Drawing.Point(553, 331);
            this.lbl_avgWaitThoseWho.Name = "lbl_avgWaitThoseWho";
            this.lbl_avgWaitThoseWho.Size = new System.Drawing.Size(60, 24);
            this.lbl_avgWaitThoseWho.TabIndex = 18;
            this.lbl_avgWaitThoseWho.Text = "label7";
            this.lbl_avgWaitThoseWho.Click += new System.EventHandler(this.lbl_avgWaitThoseWho_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 427);
            this.panel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 41);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(35, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Report";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(113, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 41);
            this.panel2.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(8, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Simulation Queueing System";
            // 
            // frmTotalResultView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(759, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_avgWaitThoseWho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_avgSpends);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_avgTimeBetwArrival);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_avgServTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ServerBusy);
            this.Controls.Add(this.lbl_IdleFrac);
            this.Controls.Add(this.lbl_ProbaWaitCust);
            this.Controls.Add(this.lbl_AvgWaitCust);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_AvgWaitTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTotalResultView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation Modeling System";
            this.Load += new System.EventHandler(this.frmDesign_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AvgWaitTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_AvgWaitCust;
        private System.Windows.Forms.Label lbl_ProbaWaitCust;
        private System.Windows.Forms.Label lbl_IdleFrac;
        private System.Windows.Forms.Label lbl_ServerBusy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_avgServTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_avgTimeBetwArrival;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_avgSpends;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_avgWaitThoseWho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
    }
}