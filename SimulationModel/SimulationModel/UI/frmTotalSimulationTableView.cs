using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SimulationModel.UI
{
    public partial class frmTotalSimulationTableView : Form
    {
        public frmTotalSimulationTableView()
        {
            InitializeComponent();
          
        }

        private SqlConnection connection =
            new SqlConnection(
                "Data Source=TOSHIBA;Initial Catalog=SimulationModelDB;Persist Security Info=True;User ID=sa;Password=a@123");



        private void frmTotalSimulationResultView_Load(object sender, EventArgs e)
        {
            getResultView();


        }

        private void DataGridArrival_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public void getResultView()
        {
            string query = "Select ArrivalRD as 'RD for Arrival',  InterArrivalTime as 'Time Since Last Arrival (Minutes)',  ArrivalTime as 'Arrival Time',  ServiceRD as 'RD for ServiceTime',  ServiceTime as 'Service Time (Minutes)',  ServiceStartTime as 'Time Service Begins',  ServiceEndTime as 'Time Service Ends',  Queue as 'Customer Wait in Queue (Minutes)',  TimeSpends as 'Customer Spends in System',  IdleTime as 'Idle Time Server (Minutes)' from tbl_TotalSimulation";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            connection.Open();
            SqlDataAdapter sdaAdapter=new SqlDataAdapter(command);

            DataTable dataTable=new DataTable();
            dataTable.Columns.Add("Customer");
            dataTable.Columns["Customer"].AutoIncrement = true;
            dataTable.Columns["Customer"].AutoIncrementSeed = 1;
           
            sdaAdapter.Fill(dataTable);
            gridViewTotalResult.DataSource = dataTable;

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getResultView();
        }


        public void totalSimuTableDELETE()
        {

            SqlCommand delCommand = new SqlCommand("delete from tbl_TotalSimulation", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(delCommand);




            connection.Open();

            dataAdapter.SelectCommand.ExecuteNonQuery();
            connection.Close();



        }

        private void btnTotalSimuRESET_Click(object sender, EventArgs e)
        {

            totalSimuTableDELETE();
            getResultView();
           
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {


            Document doc=new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("SimulationTable.pdf", FileMode.Create));
            doc.Open();


            Paragraph paragraph=new Paragraph("Simulation Table for Queueing Problem :");

            doc.Add(paragraph);

            PdfPTable table=new PdfPTable(gridViewTotalResult.Columns.Count);


            //add the header from the dataGV to the table
            for (int i = 0; i < gridViewTotalResult.Columns.Count; i++)
            {
                table.AddCell(new Phrase(gridViewTotalResult.Columns[i].HeaderText));


            }
            //flag the first row as a header
            table.HeaderRows = 1;

            //add the actual rows from the dataGV 
            for (int j = 0; j < gridViewTotalResult.Rows.Count; j++)
            {
                for (int k = 0; k < gridViewTotalResult.Columns.Count; k++)
                {

                    if (gridViewTotalResult[k,j].Value!=null)
                    {
                        table.AddCell(new Phrase(gridViewTotalResult[k, j].Value.ToString()));
                    }

                }
            }

            doc.Add(table);

            MessageBox.Show("Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            doc.Close();
        }
    }
}
