using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace SimulationModel.UI
{
    public partial class frmRDassign1 : Form
    {
        public frmRDassign1()
        {
            InitializeComponent();
        }

        private SqlConnection connection =
           new SqlConnection(
               "Data Source=TOSHIBA;Initial Catalog=SimulationModelDB;Persist Security Info=True;User ID=sa;Password=a@123");

        private SqlCommand cmdAT, cmdST;
        //SqlCommand Command =new SqlCommand();
        //int getAT;
        private SqlDataReader readerST, readerAT;
        private int interArrivalTiemInputed, serviceTimeInputed;
        private int calculatePerson = 0;
        private int counter = 0;
        private int arrivalRD, serviceRD;
        private TextBox txtServRD;
        // private int rnd, rnd2;
        

       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Method();
           CountCustomerCalculated();

        }

        public void CountCustomerCalculated()
        {
            connection.Close();
            string query2 = "SELECT COUNT(Queue) FROM tbl_TotalSimulation";
            SqlCommand command2 = new SqlCommand();
            command2.Connection = connection;
            command2.CommandText = query2;
            connection.Open();
            double TotalCustomer = Convert.ToInt32(command2.ExecuteScalar());
            lblShowCountCust.Text = Convert.ToString(TotalCustomer.ToString().Trim());

            connection.Close();
        }

        private void frmRDassign1_Load_1(object sender, EventArgs e)
        {
            this.ActiveControl = txtATRD;
            CountCustomerCalculated();
           // CountCustomerCalculated();
            lblFooter.Text = "Copyright " + Convert.ToChar(169) + "2016 FireFly Coders, DIU CSE-B(EVE)";
        }


        public void Method()
        {


            if (txtCalculatePerson.Text != "" && txtATRD.Text != "" && txtServRD.Text != "")
            {

                calculatePerson = Convert.ToInt32(txtCalculatePerson.Text);
                counter++;
                FindInterArrivalTimeFromRandomDegit();
                FindServiceTimeFromRandomDegit();
                CalculateFinalResult();
                MessageBox.Show("Successfully Assigned", "Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTEXTbox();

                frmMainView ob=new frmMainView();
                if (counter >= calculatePerson)
                {
                    ob.Show();
                    this.Hide();
                }

            }
            else if (txtCalculatePerson.Text == "" && txtATRD.Text != "" && txtServRD.Text != "")
            {
                MessageBox.Show("Calculate person required !", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please type all info !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        public void clearTEXTbox()
        {

            txtATRD.Text = "";
            txtServRD.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //int dd = Convert.ToInt32(txtATRD.Text);
            //counter++;

            //if (txtATRD.Text==""||txtServRD.Text=="")
            //{

            //    MessageBox.Show("Random Digit required!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
            //else
            //{

            //    Method();

            //}
            Method();





            //if (set<counter)
            //        {
            //            FindInterArrivalTimeFromRandomDegit();
            //            FindServiceTimeFromRandomDegit();
            //            CalculateFinalResult();
            //            txtATRD.Text = "";
            //            txtServRD.Text = "";
            //        }

            //        if (set == counter)
            //        {

            //            if (txtATRD.Text == "0")
            //            {
            //                // pp = 1;

            //                FindInterArrivalTimeFromRandomDegit();
            //                FindServiceTimeFromRandomDegit();
            //                CalculateFinalResult();
            //                txtATRD.Text = "";
            //                txtServRD.Text = "";
            //                //set=set+1;
            //                //MessageBox.Show("1st value must be  0");


            //            }

            //            else
            //            {

            //                MessageBox.Show("1st value must be  0");

            //            }

            //        }

            /// int dd = Convert.ToInt32(txtServRD.Text.ToString().Trim());
            //connection.Open();
            // cmd = new SqlCommand("Select * from tbl_ArrivalTime where RangeFrom <= " + dd + " and  RangeTo >= " + dd + " ", connection);
            // SqlDataReader reader = cmd.ExecuteReader();

            // while (reader.Read())
            //  {

            // txtServTimeRD.Text = reader.GetValue(1).ToString();

            // getAT = Convert.ToInt32(reader.GetValue(1).ToString())/2;
            //
            //  txtServTimeRD.Text = getAT.ToString().Trim();



        }



        public void FindInterArrivalTimeFromRandomDegit()
        {
           // System.Random random = new Random();
            //rnd = random.Next(999);
            arrivalRD = Convert.ToInt32(txtATRD.Text.ToString().Trim());
            connection.Open();

            cmdAT = new SqlCommand("Select * from tbl_ArrivalTime where RangeFrom <= " + arrivalRD + " and  RangeTo >= " + arrivalRD + " ", connection);
            readerAT = cmdAT.ExecuteReader();
            while (readerAT.Read())
            {

                //textBox1.Text = readerAT.GetValue(1).ToString();
                interArrivalTiemInputed = Convert.ToInt32(readerAT.GetValue(1).ToString());

                if (rnd < 1)
                {
                    interArrivalTiemInputed = 0;
                    //textBox1.Text = Convert.ToString(interArrivalTiemInputed);
                }
                // textBox2.Text = readerST.GetValue(1).ToString();


            }
            connection.Close();




        }
        public void FindServiceTimeFromRandomDegit()
        {
           serviceRD = Convert.ToInt32(txtServRD.Text.ToString().Trim());
           // System.Random random=new Random();
            // rnd2 = random.Next(99);


            connection.Open();

            cmdST = new SqlCommand("Select * from tbl_ServiceTime where RangeFrom <= " + serviceRD + " and  RangeTo >= " + serviceRD + " ", connection);


            readerST = cmdST.ExecuteReader();


            while (readerST.Read())
            {

                //textBox1.Text = readerAT.GetValue(1).ToString();

                //textBox2.Text = readerST.GetValue(1).ToString();
                serviceTimeInputed = Convert.ToInt32(readerST.GetValue(1).ToString());


            }

            connection.Close();



        }

        //  connection.Close();


        public List<FinalResult> getAllFinalTableInfo()
        {
            List<FinalResult> finalResultsList = new List<FinalResult>();
            string query = "Select * from tbl_TotalSimulation";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                FinalResult finalResult = new FinalResult();
                finalResult.InterArrivalTime = Convert.ToInt32(reader["InterArrivalTime"]);
                finalResult.ArrivalTime = Convert.ToInt32(reader["ArrivalTime"]);
                finalResult.ServiceTime = Convert.ToInt32(reader["ServiceTime"]);
                finalResult.ServiceStartTime = Convert.ToInt32(reader["ServiceStartTime"]);
                finalResult.ServiceEndTime = Convert.ToInt32(reader["ServiceEndTime"]);
                finalResult.Queue = Convert.ToInt32(reader["Queue"]);
                finalResult.TimeSpends = Convert.ToInt32(reader["TimeSpends"]);
                finalResult.IdleTime = Convert.ToInt32(reader["IdleTime"]);
                finalResultsList.Add(finalResult);
            }
            reader.Close();
            connection.Close();
            return finalResultsList;

        }

        public void CalculateFinalResult()
        {


            FinalResult newResult = new FinalResult();
            newResult.InterArrivalTime = interArrivalTiemInputed;
            foreach (var finalResult in getAllFinalTableInfo())
            {
                newResult.ArrivalTime = finalResult.ArrivalTime + newResult.InterArrivalTime;
            }
            newResult.ServiceTime = serviceTimeInputed;
            int previousServiceEndTiem = 0;
            foreach (var finalResult in getAllFinalTableInfo())
            {
                previousServiceEndTiem = finalResult.ServiceEndTime;
            }

            if (previousServiceEndTiem <= newResult.ArrivalTime)
            {
                newResult.ServiceStartTime = newResult.ArrivalTime;
            }
            else
            {
                newResult.ServiceStartTime = previousServiceEndTiem;
            }

            newResult.ServiceEndTime = newResult.ServiceStartTime + newResult.ServiceTime;

            int initialQueue = 0;

            if (newResult.ServiceStartTime > newResult.ArrivalTime)
            {
                newResult.Queue = newResult.ServiceStartTime - newResult.ArrivalTime;
            }
            else
            {
                newResult.Queue = initialQueue;
            }

            newResult.TimeSpends = newResult.ServiceEndTime - newResult.ArrivalTime;

            int initialIdleTime = 0;
            if (previousServiceEndTiem < newResult.ArrivalTime)
            {
                newResult.IdleTime = newResult.ArrivalTime - previousServiceEndTiem;
            }
            else
            {
                newResult.IdleTime = initialIdleTime;
            }


            SaveFinalTableData(newResult);

        }

        public void SaveFinalTableData(FinalResult finalResult)
        {
            string query = "Insert into tbl_TotalSimulation values(" + arrivalRD + "," + finalResult.InterArrivalTime + "," + finalResult.ArrivalTime + "," + serviceRD + "," + finalResult.ServiceTime + "," + finalResult.ServiceStartTime + "," + finalResult.ServiceEndTime + "," + finalResult.Queue + "," + finalResult.TimeSpends + "," + finalResult.IdleTime + ")";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
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
            frmRDassign1 ob=new frmRDassign1();
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainView ob=new frmMainView();
            ob.Show();
            this.Hide();
        }

        private void lblShowCountCust_Click(object sender, EventArgs e)
        {
           // CountCustomerCalculated();
        }

       
            

        }




    }




