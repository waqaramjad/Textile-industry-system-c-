using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.SqlClient;
using ISE_WIM.Reports;
using ISE_WIM.Simple_Forms;

namespace ISE_WIM
{
    public partial class Production : MetroForm
    {
        string qury = "select * from Contract1";
        string q1 = "select * from LoomType";
        string q2 = "select * from Manager1";
        string connection = @"Data Source=WAQARAMJAD;Initial Catalog=WIM;Integrated Security=True ";
        string qury1;
        public Production()
        {
            InitializeComponent();
           LoadLloomType(q1, "loom_type", metroComboBox1);
           LoadLloomType(qury, "Contract_ID", metroComboBox5);
           LoadLloomType(q2, "Manager_Name", managerName);
        }

        private void Production_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iSE_WIMDataSet.LoomType' table. You can move, or remove it, as needed.
            //this.loomTypeTableAdapter.Fill(this.iSE_WIMDataSet.LoomType);
            qury = "select Loom_type from LoomType";
            DataTable dt = new DataTable();
            dt = Sql.Search(qury);
            Loom_No.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Loom_No.Items.Add(dt.Rows[i][0].ToString());
            }
            LoadShift();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadLloomType(string q, string c,ComboBox A)
        {
            SqlConnection loonnumber = new SqlConnection(connection);
            {
                loonnumber.Open();
                A.Items.Clear();
                SqlCommand cmdd = new SqlCommand(q, loonnumber);
                SqlDataReader Reader = cmdd.ExecuteReader();
                while (Reader.Read())
                {
                    A.Items.Add(Reader[c]);

                }
                loonnumber.Close();
            }
        }
        public void LoadShift()
        {
            SqlConnection con1 = new SqlConnection(connection);
            //dt = new DataTable();
            string query = "select Shift_Type from Shift";
            SqlCommand cmd = new SqlCommand(query, con1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            metroComboBox2.DataSource = dt;
            metroComboBox2.DisplayMember = "Shift_Type";
        }
        Sql_Class Sql = new Sql_Class();

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //qury1 = "insert into ProductionReport_LineItem(PRd_Date, PR_Loom_No, PRd_Shift, PRd_Unit) values ('" + metroDateTime1.Value + "', '" + metroComboBox3.Text + "','" + metroComboBox2.Text + "', '" + metroTextBox1.Text + "')";
            //Sql.Insert_Update_Delete(qury1);
            qury1 = "insert into Production_Report (M_ID, PRd_ID,PR_DATE) values ('" + managerID.Text + "', '" + metroComboBox5.Text + "','"+metroDateTime1.Value.ToShortDateString() + "')";
            Sql.Insert_Update_Delete(qury1);
            MessageBox.Show("Added Successfully");
        }

        private void addBtnForGrid_Click(object sender, EventArgs e)
        {
            double totDay = 0, totNight = 0,tempDay,tempNight,totMtr;
            string loomNoString, dayString, nightString,query;
            //for (int i = 0; i < productionGrid.Rows.Count - 1; i++)
            {
                try
                {
              //      loomNoString = productionGrid.Rows[i].Cells[0].Value.ToString();
                //    dayString = productionGrid.Rows[i].Cells[1].Value.ToString();
                  //  nightString = productionGrid.Rows[i].Cells[2].Value.ToString();
                    //tempDay = Double.Parse(dayString);
                    //tempNight = Double.Parse(nightString);
                    //totDay += tempDay;
                    //totNight += tempNight;
                //    query = "insert into ProductionReport_LineItem (PRd_Date,PR_Loom_No,PRd_Shift,PRd_Unit) values (getdate(),'" + loomNoString + "','Night'," + nightString + ")";
                  //  Sql.Insert_Update_Delete(query);
                    //query = "insert into ProductionReport_LineItem (PRd_Date,PR_Loom_No,PRd_Shift,PRd_Unit) values (getdate(),'" +loomNoString + "','Day'," + dayString + ")";
                   // Sql.Insert_Update_Delete(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
          //  totMtr = totDay + totNight;

        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            qury1 = "select Manager_ID from Manager1 where Manager_Name = '"+ managerName .Text+ "'";
            DataTable dt = new DataTable();
            dt = Sql.Search(qury1);
            managerID.Text = dt.Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtnForGrid_Click2(object sender, EventArgs e)
        {
            production_report_viewer abc = new production_report_viewer();
            abc.ShowDialog();
        }

        private void addBtnForGrid_Click23(object sender, EventArgs e)
        {
            ViewProductionRecord vp = new ViewProductionRecord();
            vp.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
