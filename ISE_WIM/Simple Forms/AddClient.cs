using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace ISE_WIM.Simple_Forms
{
    public partial class AddClient : Form
    {
        string connection = @"Data Source=WAQARAMJAD;Initial Catalog=WIM;Integrated Security=True ";
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Client1", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0].DefaultView;
            
            con.Close();
        }

        private void metroBtn_manager_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insert_sqll = "INSERT INTO Client1(  Client_Name, Client_Title, Client_StartDate, Client_EndDate, Client_Contact, Client_Email, Client_Address, Client_CompanyName,Client_Status)VALUES( '" + metroTB_Manager_Name.Text + "','" + metroTB_Manager_FName.Text + "','" + metroDTime_Manager_Start.Value.ToShortDateString() + "','" + metroDTime_Manager_End.Value.ToShortDateString() + "','" + metroTB_Manager_Contact.Text + "','" + metroTB_Manager_Email.Text + "','" + richTB_manager_Address.Text + "','" + metroTB_Manager_CNIC.Text + "','" + metroTB_Manager_Status.Text + "')";
                this.getcom(insert_sqll);
                MessageBox.Show("Successfully Added");
            }
            catch (Exception ex)
            { MessageBox.Show("Wrong transaction is being executed : "+ex); }
        }
        public SqlConnection GetSqlCon()
        {
            string M_str_sqlcon = this.connection;
            SqlConnection myCon = new SqlConnection(M_str_sqlcon);
            myCon.Open();
            return myCon;
        }
        public void getcom(string M_str_sqlstr)
        {
            SqlConnection sqlcon = this.GetSqlCon();
            SqlCommand sqlcom = new SqlCommand(M_str_sqlstr, sqlcon);
            sqlcom.ExecuteNonQuery();
            sqlcom.Dispose();
            sqlcon.Close();
            sqlcon.Dispose();
        }

        private void metroBtn_manager_View_Click(object sender, EventArgs e)
        {
            Clear();
            AddClient_Load(sender, e);
        }
        public void Clear()
        {
            metroTB_Manager_ID.Clear();
            metroTB_Manager_Name.Clear();
            metroTB_Manager_FName.Clear();
            metroTB_Manager_CNIC.Clear();
            metroDTime_Manager_Start.ResetText();
            metroDTime_Manager_End.ResetText();
            metroTB_Manager_Contact.Clear();
            metroTB_Manager_Email.Clear();
            richTB_manager_Address.Clear();
            metroTB_Manager_Status.Clear();
    }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTB_Manager_ID_Click(object sender, EventArgs e)
        {

        }

        private void metroTB_Manager_Name_Click(object sender, EventArgs e)
        {

        }

        private void metroTB_Manager_FName_Click(object sender, EventArgs e)
        {

        }

        private void metroDTime_Manager_Start_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroDTime_Manager_End_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroTB_Manager_Contact_Click(object sender, EventArgs e)
        {

        }

        private void metroTB_Manager_Email_Click(object sender, EventArgs e)
        {

        }

        private void richTB_manager_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTB_Manager_Status_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}