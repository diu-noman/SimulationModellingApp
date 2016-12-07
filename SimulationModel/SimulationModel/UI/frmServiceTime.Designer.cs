namespace SimulationModel.UI
{
    partial class frmServiceTime
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceTime));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServADD = new System.Windows.Forms.Button();
            this.txtServRangeTo = new System.Windows.Forms.TextBox();
            this.txtServRangeFrom = new System.Windows.Forms.TextBox();
            this.txtServiceTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnServRESET = new System.Windows.Forms.Button();
            this.DataGridService = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireFlyCodersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abdullahAlNomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.chanchalMollahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mahmudulHasanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mohiturRahmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrivalTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignRDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridService)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Distribution of  Service Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ServiceTime";
            // 
            // btnServADD
            // 
            this.btnServADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServADD.Location = new System.Drawing.Point(285, 175);
            this.btnServADD.Name = "btnServADD";
            this.btnServADD.Size = new System.Drawing.Size(54, 26);
            this.btnServADD.TabIndex = 13;
            this.btnServADD.Text = "ADD";
            this.btnServADD.UseVisualStyleBackColor = true;
            this.btnServADD.Click += new System.EventHandler(this.btnServADD_Click);
            // 
            // txtServRangeTo
            // 
            this.txtServRangeTo.Location = new System.Drawing.Point(228, 145);
            this.txtServRangeTo.Name = "txtServRangeTo";
            this.txtServRangeTo.Size = new System.Drawing.Size(109, 20);
            this.txtServRangeTo.TabIndex = 12;
            // 
            // txtServRangeFrom
            // 
            this.txtServRangeFrom.Location = new System.Drawing.Point(228, 111);
            this.txtServRangeFrom.Name = "txtServRangeFrom";
            this.txtServRangeFrom.Size = new System.Drawing.Size(109, 20);
            this.txtServRangeFrom.TabIndex = 11;
            // 
            // txtServiceTime
            // 
            this.txtServiceTime.Location = new System.Drawing.Point(228, 78);
            this.txtServiceTime.Name = "txtServiceTime";
            this.txtServiceTime.Size = new System.Drawing.Size(108, 20);
            this.txtServiceTime.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Range-From";
            // 
            // btnServRESET
            // 
            this.btnServRESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServRESET.Location = new System.Drawing.Point(231, 175);
            this.btnServRESET.Name = "btnServRESET";
            this.btnServRESET.Size = new System.Drawing.Size(58, 26);
            this.btnServRESET.TabIndex = 16;
            this.btnServRESET.Text = "RESET";
            this.btnServRESET.UseVisualStyleBackColor = true;
            this.btnServRESET.Click += new System.EventHandler(this.btnServRESET_Click);
            // 
            // DataGridService
            // 
            this.DataGridService.AllowUserToAddRows = false;
            this.DataGridService.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridService.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridService.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridService.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridService.Location = new System.Drawing.Point(26, 217);
            this.DataGridService.Name = "DataGridService";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridService.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridService.Size = new System.Drawing.Size(313, 137);
            this.DataGridService.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFooter);
            this.panel1.Location = new System.Drawing.Point(-5, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 23);
            this.panel1.TabIndex = 19;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFooter.Location = new System.Drawing.Point(52, 2);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(55, 15);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "lblFooter";
            this.lblFooter.Click += new System.EventHandler(this.label5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.teamToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fireFlyCodersToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.teamToolStripMenuItem.Text = "Team";
            // 
            // fireFlyCodersToolStripMenuItem
            // 
            this.fireFlyCodersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abdullahAlNomanToolStripMenuItem,
            this.chanchalMollahToolStripMenuItem,
            this.mahmudulHasanToolStripMenuItem,
            this.mohiturRahmanToolStripMenuItem});
            this.fireFlyCodersToolStripMenuItem.Name = "fireFlyCodersToolStripMenuItem";
            this.fireFlyCodersToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.fireFlyCodersToolStripMenuItem.Text = "FireFly Coders";
            // 
            // abdullahAlNomanToolStripMenuItem
            // 
            this.abdullahAlNomanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.abdullahAlNomanToolStripMenuItem.Name = "abdullahAlNomanToolStripMenuItem";
            this.abdullahAlNomanToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.abdullahAlNomanToolStripMenuItem.Text = "Abdullah Al Noman";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem2.Text = "143-15-4230";
            // 
            // chanchalMollahToolStripMenuItem
            // 
            this.chanchalMollahToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.chanchalMollahToolStripMenuItem.Name = "chanchalMollahToolStripMenuItem";
            this.chanchalMollahToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.chanchalMollahToolStripMenuItem.Text = "Chanchal Mollah";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem3.Text = "111-15-1216";
            // 
            // mahmudulHasanToolStripMenuItem
            // 
            this.mahmudulHasanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.mahmudulHasanToolStripMenuItem.Name = "mahmudulHasanToolStripMenuItem";
            this.mahmudulHasanToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.mahmudulHasanToolStripMenuItem.Text = "Mahmudul Hasan";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem4.Text = "143-15-4224";
            // 
            // mohiturRahmanToolStripMenuItem
            // 
            this.mohiturRahmanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5});
            this.mohiturRahmanToolStripMenuItem.Name = "mohiturRahmanToolStripMenuItem";
            this.mohiturRahmanToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.mohiturRahmanToolStripMenuItem.Text = "Mohitur Rahman";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem5.Text = "142-15-4216";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem,
            this.assignRDToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrivalTimeToolStripMenuItem,
            this.serviceTimeToolStripMenuItem});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sToolStripMenuItem.Text = "ADD";
            // 
            // arrivalTimeToolStripMenuItem
            // 
            this.arrivalTimeToolStripMenuItem.Name = "arrivalTimeToolStripMenuItem";
            this.arrivalTimeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.arrivalTimeToolStripMenuItem.Text = "ArrivalTime";
            this.arrivalTimeToolStripMenuItem.Click += new System.EventHandler(this.arrivalTimeToolStripMenuItem_Click);
            // 
            // serviceTimeToolStripMenuItem
            // 
            this.serviceTimeToolStripMenuItem.Name = "serviceTimeToolStripMenuItem";
            this.serviceTimeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.serviceTimeToolStripMenuItem.Text = "ServiceTime";
            this.serviceTimeToolStripMenuItem.Click += new System.EventHandler(this.serviceTimeToolStripMenuItem_Click);
            // 
            // assignRDToolStripMenuItem
            // 
            this.assignRDToolStripMenuItem.Name = "assignRDToolStripMenuItem";
            this.assignRDToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.assignRDToolStripMenuItem.Text = "Assign RD";
            this.assignRDToolStripMenuItem.Click += new System.EventHandler(this.assignRDToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationTableToolStripMenuItem,
            this.resultToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // simulationTableToolStripMenuItem
            // 
            this.simulationTableToolStripMenuItem.Name = "simulationTableToolStripMenuItem";
            this.simulationTableToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.simulationTableToolStripMenuItem.Text = "Simulation Table";
            this.simulationTableToolStripMenuItem.Click += new System.EventHandler(this.simulationTableToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.resultToolStripMenuItem.Text = "Result";
            this.resultToolStripMenuItem.Click += new System.EventHandler(this.resultToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(20, 177);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 24);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmServiceTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 383);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGridService);
            this.Controls.Add(this.btnServRESET);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnServADD);
            this.Controls.Add(this.txtServRangeTo);
            this.Controls.Add(this.txtServRangeFrom);
            this.Controls.Add(this.txtServiceTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmServiceTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation Modeling System";
            this.Load += new System.EventHandler(this.frmServiceTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridService)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnServADD;
        private System.Windows.Forms.TextBox txtServRangeTo;
        private System.Windows.Forms.TextBox txtServRangeFrom;
        private System.Windows.Forms.TextBox txtServiceTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnServRESET;
        private System.Windows.Forms.DataGridView DataGridService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireFlyCodersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abdullahAlNomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chanchalMollahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mahmudulHasanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mohiturRahmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrivalTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignRDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}