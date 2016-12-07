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
    public partial class frmTotalResultView : Form
    {
        public frmTotalResultView()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=TOSHIBA;Initial Catalog=SimulationModelDB;Persist Security Info=True;User ID=sa;Password=a@123");

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        public void FindAllResult()
        {
            
            
            string query = "SELECT COUNT(Queue) FROM tbl_TotalSimulation where Queue!=0";
            string query2 = "SELECT COUNT(Queue) FROM tbl_TotalSimulation";
            string query3 = "SELECT AVG(Queue) FROM tbl_TotalSimulation";
            string query4 = "SELECT SUM(Queue) FROM tbl_TotalSimulation";
            string query5 = "SELECT MAX(ServiceEndTime) FROM tbl_TotalSimulation";
            string query6 = "SELECT SUM(IdleTime) FROM tbl_TotalSimulation";
            string query7 = "SELECT AVG(ServiceTime) FROM tbl_TotalSimulation";
            string query8 = "SELECT MAX(ArrivalTime) FROM tbl_TotalSimulation";
            string query9 = "SELECT SUM(TimeSpends) FROM tbl_TotalSimulation";


            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;

            SqlCommand command2=new SqlCommand();
            command2.Connection = connection;
            command2.CommandText = query2;

            SqlCommand command3 = new SqlCommand();
            command3.Connection = connection;
            command3.CommandText = query3;

            SqlCommand command4 = new SqlCommand();
            command4.Connection = connection;
            command4.CommandText = query4;

            SqlCommand command5 = new SqlCommand();
            command5.Connection = connection;
            command5.CommandText = query5;

            SqlCommand command6 = new SqlCommand();
            command6.Connection = connection;
            command6.CommandText = query6;

            SqlCommand command7 = new SqlCommand();
            command7.Connection = connection;
            command7.CommandText = query7;

            SqlCommand command8 = new SqlCommand();
            command8.Connection = connection;
            command8.CommandText = query8;

            SqlCommand command9 = new SqlCommand();
            command9.Connection = connection;
            command9.CommandText = query9;

            connection.Open();
            double countQueueCustomer = Convert.ToDouble(command.ExecuteScalar());
            double TotalCustomer = Convert.ToInt32(command2.ExecuteScalar());
           double sumQueue = Convert.ToInt32(command4.ExecuteScalar());
           
            double totalRunTime = Convert.ToDouble(command5.ExecuteScalar());
            double sumIdleTime = Convert.ToDouble(command6.ExecuteScalar());
            double avgServiceTime = Convert.ToDouble(command7.ExecuteScalar());
            double sumInterArrival = Convert.ToDouble(command8.ExecuteScalar());
            double sumTimeSpends = Convert.ToDouble(command9.ExecuteScalar());
            connection.Close();

            double avgWait = sumQueue/TotalCustomer;
            double countQueue = countQueueCustomer/TotalCustomer;
            float fractionIdleTimeServer = Convert.ToSingle(sumIdleTime/totalRunTime);
            float probalityServerBusy = 1 - fractionIdleTimeServer;
            float avgTimeBetweenArrival = Convert.ToSingle(sumInterArrival/(TotalCustomer - 1));
            float avgCustWhoWait = Convert.ToSingle(sumQueue/countQueueCustomer);
            float avgCustSpends = Convert.ToSingle(sumTimeSpends/TotalCustomer);
            

            lbl_AvgWaitCust.Text = avgWait.ToString().Trim()+" (min)";
            lbl_ProbaWaitCust.Text = countQueue.ToString().Trim();
            lbl_IdleFrac.Text = fractionIdleTimeServer.ToString().Trim();
            lbl_ServerBusy.Text = probalityServerBusy.ToString().Trim();
            lbl_avgServTime.Text = avgServiceTime.ToString().Trim()+" (min)";
            lbl_avgTimeBetwArrival.Text = avgTimeBetweenArrival.ToString().Trim()+" (min)";
            lbl_avgWaitThoseWho.Text = avgCustWhoWait.ToString().Trim()+" (min)";
            lbl_avgSpends.Text = avgCustSpends.ToString().Trim()+" (min)";
           



        }


       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {

        }

        private void dataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            frmArrivalTime obb=new frmArrivalTime();
            obb.Show();
           
          this.Hide();
            
        }

        private void lbl_avgSpends_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_avgTimeBetwArrival_Click(object sender, EventArgs e)
        {

        }

        private void lbl_avgWaitThoseWho_Click(object sender, EventArgs e)
        {

        }

        private void frmDesign_Load(object sender, EventArgs e)
        {
            FindAllResult();
        }
    }
}
