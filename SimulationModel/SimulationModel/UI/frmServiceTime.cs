using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace SimulationModel.UI
{
    public partial class frmServiceTime : Form
    {
        public frmServiceTime()
        {
            InitializeComponent();
        }

        private SqlConnection connection = new SqlConnection("Data Source=TOSHIBA;Initial Catalog=SimulationModelDB;Persist Security Info=True;User ID=sa;Password=a@123");
         SqlCommand cmd;
        private SqlDataAdapter sda;

        public void txtValue() {
            string sTime = txtServiceTime.Text;
            string sRangeFrom = txtServRangeFrom.Text;
            string sRangeTo = txtServRangeTo.Text;
        
        
        }

        public void InsertServiceTimeValue() {

            connection.Open();
            cmd = new SqlCommand("INSERT INTO tbl_ServiceTime(ServiceTime,RangeFrom,RangeTo) VALUES('" +txtServiceTime.Text + "','" + txtServRangeFrom.Text + "','" + txtServRangeTo.Text + "')", connection);
            sda = new SqlDataAdapter(cmd);
           sda.SelectCommand.ExecuteNonQuery();
           
            connection.Close();
            MessageBox.Show("ADD Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        


        }


        public void serviceGridView() {

            connection.Open();
            cmd = new SqlCommand("select ServiceTime,RangeFrom,RangeTo from tbl_ServiceTime", connection);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataGridService.DataSource = dt;
       connection.Close();

        
        
        
        }


        private void frmServiceTime_Load(object sender, EventArgs e)
        {
            serviceGridView();
            lblFooter.Text = "Copyright " + Convert.ToChar(169) + "2016 FireFly Coders, DIU CSE-B(EVE)";
        }

        public void clearServTextBox()
        {
            txtServiceTime.Text = "";
            txtServRangeFrom.Text = "";
            txtServRangeTo.Text = "";

        }

        private void btnServADD_Click(object sender, EventArgs e)
        {

            if (txtServiceTime.Text != "" && txtServRangeFrom.Text != "" && txtServRangeTo.Text != "")
            {
                connection.Close();
                InsertServiceTimeValue();
                clearServTextBox();
                serviceGridView();

                //serviceGridView();


            }
            else {

                MessageBox.Show("Please fillup all text required!","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            
            
            }

            
        }

        public void deleteServiceTableValue()
        {
            SqlCommand delCommand = new SqlCommand("delete from tbl_ServiceTime", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(delCommand);




            connection.Open();

            dataAdapter.SelectCommand.ExecuteNonQuery();
            connection.Close();



        }

        private void btnServRESET_Click(object sender, EventArgs e)
        {


            deleteServiceTableValue();
            serviceGridView();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            //int dd = Convert.ToInt32(txtServiceTime.Text.ToString().Trim());

            //connection.Open();
            //IDataReader dr = null;
            //String strQuery = "Select * from tbl_ArrivalTime where RangeFrom <= " + dd + " and  RangeTo >= " + dd + " ";
            //dr = SqlHelper.ExecuteReader (connection,CommandType.Text,strQuery);
            
                
           
            
            

            //while (dr.Read())
            //{
            //    txtServRangeFrom.Text = dr.GetValue(1).ToString();
            //    int p = Convert.ToInt32(dr.GetValue(1).ToString());
            
            //}


            ////sda = new SqlDataAdapter(cmd);
            ////DataTable dt = new DataTable();
            ////sda.Fill(dt);

            ////DataGridService.DataSource = dt;
            //connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            connection.Close();
            serviceGridView();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainView ob=new frmMainView();
            ob.Show();
            this.Hide();
        }

        private void arrivalTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArrivalTime ob=new frmArrivalTime();
            ob.Show();
            this.Hide();
        }

        private void serviceTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServiceTime ob=new frmServiceTime();
            ob.Show();
            this.Hide();
        }

        private void assignRDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSimulate ob = new frmSimulate();
            ob.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainView ob=new frmMainView();
            ob.Show();
            this.Hide();
        }

        private void simulationTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTotalSimulationTableView ob=new frmTotalSimulationTableView();
            ob.Show();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTotalResultView ob=new frmTotalResultView();
            ob.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            lblFooter.Text = "Copyright "+Convert.ToChar(169)+"2016 FireFly Coders, DIU CSE-B(EVE)";
        }
    }
}
