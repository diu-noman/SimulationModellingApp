using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SimulationModel.UI
{
    public partial class frmArrivalTime : Form
    {
        public frmArrivalTime()
        {
            InitializeComponent();
        }

        private SqlConnection connection =
            new SqlConnection(
                "Data Source=TOSHIBA;Initial Catalog=SimulationModelDB;Persist Security Info=True;User ID=sa;Password=a@123");

        private SqlCommand command;
        private SqlDataAdapter sda;
        private DataTable dt;


        public void InsertArrivalValue()
        {

            connection.Open();
            command =
                new SqlCommand(
                    "INSERT INTO tbl_ArrivalTime(ArrivalTime,RangeFrom,RangeTo) VALUES('" + txtArrivalTime.Text + "','" +
                    txtRangeFrom.Text + "','" + txtRangeTo.Text + "')", connection);
            sda = new SqlDataAdapter(command);
            sda.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Add Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }



        public void arrivalGridview()
        {
            //con.Close();
            connection.Open();
            command = new SqlCommand("select ArrivalTime,RangeFrom,RangeTo from tbl_ArrivalTime", connection);
            sda = new SqlDataAdapter(command);
             dt = new DataTable();

           
            
           // dt.Columns.Add("SlNo");
           // dt.Columns["SlNo"].AutoIncrement = true;
            //dt.Columns["SlNo"].AutoIncrementSeed = 1;
            sda.Fill(dt);

            DataGridArrival.DataSource = dt;
            connection.Close();

        }

        private void frmArrivalTime_Load(object sender, EventArgs e)
        {
            arrivalGridview();
            lblFooter.Text = "Copyright " + Convert.ToChar(169) + "2016 FireFly Coders, DIU CSE-B(EVE)";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void clearArrivalTextBox()
        {


            txtArrivalTime.Text = "";
            txtRangeFrom.Text = "";
            txtRangeTo.Text = "";

        }

        private void btnArriSave_Click(object sender, EventArgs e)
        {
            if (txtArrivalTime.Text != "" && txtRangeFrom.Text != "" && txtRangeTo.Text != "")
            {
                connection.Close();
                InsertArrivalValue();
                clearArrivalTextBox();
                arrivalGridview();
                
                // arrivalGridview();

            }
            else
            {

                MessageBox.Show("All data required !","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Stop);

            }



        }

        private void txtArrivalTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridArrival_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public void deleteArrivalTableValue()
        {

           
            
            
           // connection.Close();
            SqlCommand delCommand = new SqlCommand("delete from tbl_ArrivalTime",connection);
            SqlDataAdapter dataAdapter=new SqlDataAdapter(delCommand);
           
            
            
            
            connection.Open();
          
            dataAdapter.SelectCommand.ExecuteNonQuery();
            connection.Close();

        }

        public void btnView_Click(object sender, EventArgs e)
        {
            //connection.Close();
           // arrivalGridview();
            




        }

        private void btnArriRESET_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow item in this.DataGridArrival.SelectedRows)
            //{
            //    DataGridArrival.Rows.RemoveAt(item.Index);
            //}

            deleteArrivalTableValue();

            arrivalGridview();


        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainView ob=new frmMainView();
            ob.Show();
            this.Hide();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arrivalTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainView ob=new frmMainView();
            ob.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
