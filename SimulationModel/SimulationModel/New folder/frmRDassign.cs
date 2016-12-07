using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SimulationModel.UI;

namespace SimulationModel
{
    public partial class frmMain : Form
    {

        public frmMain()
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtATRD;
           // txtATRD.Focus();

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
                        clearTEXTbox();
                        if (counter >= calculatePerson)
                        {
                            this.Close();
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

        public void Match()
        {


            if (txtCalculatePerson.Text != "")
            {


                counter++;
                FindInterArrivalTimeFromRandomDegit();
                FindServiceTimeFromRandomDegit();
                CalculateFinalResult();
                clearTEXTbox();
                if (counter >= calculatePerson)
                {
                    this.Close();
                }


            }


            else
            {

                MessageBox.Show("Calculate person required !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            arrivalRD = Convert.ToInt32(txtATRD.Text.ToString().Trim());
            connection.Open();

            cmdAT = new SqlCommand("Select * from tbl_ArrivalTime where RangeFrom <= " + arrivalRD + " and  RangeTo >= " + arrivalRD + " ", connection);
            readerAT = cmdAT.ExecuteReader();
            while (readerAT.Read())
            {
                
                //textBox1.Text = readerAT.GetValue(1).ToString();
                interArrivalTiemInputed = Convert.ToInt32(readerAT.GetValue(1).ToString());

                if (arrivalRD<1)
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
              
           
                FinalResult newResult=new FinalResult();
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

                if (previousServiceEndTiem<=newResult.ArrivalTime)
                {
                    newResult.ServiceStartTime = newResult.ArrivalTime;
                }
                else
                {
                    newResult.ServiceStartTime = previousServiceEndTiem;
                }

            newResult.ServiceEndTime = newResult.ServiceStartTime + newResult.ServiceTime;

            int initialQueue = 0;

            if (newResult.ServiceStartTime>newResult.ArrivalTime)
            {
                newResult.Queue = newResult.ServiceStartTime - newResult.ArrivalTime;
            }
            else
            {
                newResult.Queue = initialQueue;
            }

            newResult.TimeSpends = newResult.ServiceEndTime - newResult.ArrivalTime;

            int initialIdleTime = 0;
            if (previousServiceEndTiem<newResult.ArrivalTime)
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
            string query = "Insert into tbl_TotalSimulation values("+arrivalRD+","+finalResult.InterArrivalTime+","+finalResult.ArrivalTime+","+serviceRD+","+finalResult.ServiceTime+","+finalResult.ServiceStartTime+","+finalResult.ServiceEndTime+","+finalResult.Queue+","+finalResult.TimeSpends+","+finalResult.IdleTime+")";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

       

       

      

    }
}
