using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SimulationModel.UI
{
    public partial class frmMainView : Form
    {
        public frmMainView()
        {
            InitializeComponent();
        }

      

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arrivalTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArrivalTime ob = new frmArrivalTime();
            ob.Show();
            this.Hide();

        }

        private void serviceTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmServiceTime ob = new frmServiceTime();
            ob.Show();
            this.Hide();
        }

        private void assignRDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSimulate ob = new frmSimulate();
            ob.Show();
            //this.Hide();
        }

        private void simulationTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTotalSimulationTableView ob = new frmTotalSimulationTableView();
            ob.Show();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTotalResultView ob = new frmTotalResultView();
            ob.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmMainView_Load(object sender, EventArgs e)
        {

            lbl1.Parent = pictureBox1;
            lbl1.BackColor = Color.Transparent;
            lbl2.Parent = pictureBox1;
            lbl2.BackColor = Color.Transparent;
            lbl3.Parent = pictureBox1;
            lbl3.BackColor = Color.Transparent;
            lbl4.Parent = pictureBox1;
            lbl4.BackColor = Color.Transparent;
            lbl5.Parent = pictureBox1;
            lbl5.BackColor = Color.Transparent;

            lblWorkFlow.Parent = pictureBox1;
            lblWorkFlow.BackColor = Color.Transparent;


            lblFooter.Text = "Copyright " + Convert.ToChar(169) + "2016 FireFly Coders, DIU CSE-B(EVE)";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmTotalResultView ob = new frmTotalResultView();
            ob.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            //label2.ForeColor = Color.Chartreuse;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            //label2.ForeColor = Color.Blue;
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            frmServiceTime ob = new frmServiceTime();
            ob.Show();
            this.Hide();
        }
       
       

        private void lbl1_MouseEnter(object sender, EventArgs e)
        {

            lbl1.ForeColor = Color.ForestGreen;

        }

        private void lbl1_MouseLeave(object sender, EventArgs e)
        {
            lbl1.ForeColor = Color.FloralWhite;
        }

        private void lbl2_MouseEnter(object sender, EventArgs e)
        {
            lbl2.ForeColor = Color.DodgerBlue;
        }

        private void lbl2_MouseLeave(object sender, EventArgs e)
        {
            lbl2.ForeColor = Color.FloralWhite;
        }

        private void lbl3_MouseEnter(object sender, EventArgs e)
        {
            lbl3.ForeColor = Color.Blue;
        }

        private void lbl3_MouseLeave(object sender, EventArgs e)
        {
            lbl3.ForeColor = Color.FloralWhite;
        }

        private void lbl4_MouseEnter(object sender, EventArgs e)
        {
            lbl4.ForeColor = Color.BlueViolet;
        }

        private void lbl4_MouseLeave(object sender, EventArgs e)
        {
            lbl4.ForeColor = Color.FloralWhite;
        }

        private void lbl5_MouseEnter(object sender, EventArgs e)
        {
            lbl5.ForeColor = Color.Brown;
        }

        private void lbl5_MouseLeave(object sender, EventArgs e)
        {
            lbl5.ForeColor = Color.FloralWhite;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            frmArrivalTime ob = new frmArrivalTime();
            ob.Show();
            this.Hide();
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            frmTotalResultView ob = new frmTotalResultView();
            ob.Show();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            frmSimulate ob=new frmSimulate();
            ob.Show();
           // this.Hide();
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            frmTotalSimulationTableView ob = new frmTotalSimulationTableView();
            ob.Show();
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        
      

    }
}
