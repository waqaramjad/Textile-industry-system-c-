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
using System.Data.Sql;
using System.Data.SqlClient;
using ISE_WIM.Control_Classes;
using ISE_WIM.Reports;

namespace ISE_WIM
{
    public partial class Invoice : Form
    {
        Invoice_CONTROL invoice;
        string connection = @"Data Source=WAQARAMJAD;Initial Catalog=WIM;Integrated Security=True ";

        DataTable dt;

        ~Invoice()
        {
            GC.Collect();
        }
        public Invoice()
        {
            invoice = new Invoice_CONTROL();
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 = new SqlConnection(connection);
                con1.Open();
                SqlCommand cmd1 = con1.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from Manager1 where Manager_Name like('" + metroComboBox1.SelectedItem + "')";
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    managerID.Text = reader.GetInt32(0).ToString();
                }
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        public void AddDGVColumns()
        {
            SqlConnection con = new SqlConnection(connection);

            DataGridViewComboBoxColumn dcom = new DataGridViewComboBoxColumn();

        }

        public void LoadContract_ID()
        {
            SqlConnection con1 = new SqlConnection(connection);
            //dt = new DataTable();
            string query = "select Contract_ID from [contract1]";
            SqlCommand cmd = new SqlCommand(query, con1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            contractID.DataSource = dt;
            contractID.DisplayMember = "Contract_ID";
        }


        private void Invoice_Load(object sender, EventArgs e)
        {

            LoadContract_ID();
            LoadBuyerID();
            //SqlConnection CustomerName = new SqlConnection(connection);
            //{
            //    CustomerName.Open();

            //    string q = "SELECT Manager_Name FROM Manager";
            //    SqlCommand cmdd = new SqlCommand(q, CustomerName);
            //    SqlDataReader Reader = cmdd.ExecuteReader();
            //    while (Reader.Read())
            //    {
            //        comboBox1.Items.Add(Reader["Manager_Name"]);

            //    }
            //    CustomerName.Close();
            //}
            try
            {
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Invoice1", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                metroGrid_PLLI.DataSource = ds.Tables[0].DefaultView;
                con.Close();

                SqlConnection CustomerName = new SqlConnection(connection);
                {
                    CustomerName.Open();

                    string q = "SELECT Manager_Name FROM Manager1";
                    SqlCommand cmdd = new SqlCommand(q, CustomerName);
                    SqlDataReader Reader = cmdd.ExecuteReader();
                    while (Reader.Read())
                    {
                        metroComboBox1.Items.Add(Reader["Manager_Name"]);

                    }
                    CustomerName.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void metroBtn_Add_Click(object sender, EventArgs e)
        {

            string insert_sqll = "INSERT INTO Invoice1(I_Serial_No,I_Contract_No,I_total_Amount,I_Description,I_Status)VALUES('" + serialInvoice.Text + "','" + contractInvoice.Text + "','" + statusInvoice.Text + "','" + descInvoice.Text + "','" + statusInvoice.Text + "')";
            this.getcom(insert_sqll);
            MessageBox.Show("Successfully Added");

            try
            {


                //string insert_sqll = "INSERT INTO Manager(Manager_ID,Manager_Name,Manager_FatherName,Manager_CNIC,Manager_Type,Manager_Username,Manager_Password,Manager_Address,Manager_Status)VALUES('" + metroTB_Manager_ID.Text + "','" + metroTB_Manager_Name.Text + "','" + metroTB_Manager_FName.Text + "','" + metroTB_Manager_CNIC.Text + "','" + metroDTime_Manager_Start.Value.ToShortDateString() + "','" + metroDTime_Manager_End.Value.ToShortDateString() + "','" + metroTB_Manager_Contact.Text + "','" + metroTB_Manager_Email.Text + "','" + metroTB_Manager_Auth.Text + "','" + metroTB_Manager_Type.Text + "','" + metroTB_Manager_Username.Text + "','" + metroTB_Manager_Pass.Text + "','" + richTB_manager_Address.Text + "','" + metroTB_Manager_Status.Text + "')";
                //string insert_sqll = "INSERT INTO Invoice(I_Date,I_Serial_No,I_Contract_No,I_total_Amount,I_TotalMeter,I_Description,I_Status,Buyer_name,Manager_ID,Contract_ID)VALUES('" + dateInvoice.Value.ToShortDateString() + "','" + serialInvoice.Text + "','" + contractInvoice.Text + "','" + totAmountInvoice.Text + "','" + totMtrInvoice.Text + "','" + descInvoice.Text + "','" + statusInvoice.Text + "','"+buyerName.Text+"','" + metroTextBox1.Text +"','"+metroComboBox2.Text+"')";
                //this.getcom(insert_sqll);
               // invoice.InsertValues(dateInvoice.Text, serialInvoice.Text, totAmountInvoice.Text, contractInvoice.Text, descInvoice.Text, managerID.Text, statusInvoice.Text, totMtrInvoice.Text, buyerID.Text, contractID.Text);
                    MessageBox.Show("Successfully Added");
                
            }


            catch (Exception ex)
            {
                MessageBox.Show("Wrong transaction is being executed");
            }
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

        private void metroBtn_View_Click(object sender, EventArgs e)
        {
            Invoice_Load(sender, e);
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection con1 = new SqlConnection(connection);
            //    con1.Open();
            //    SqlCommand cmd1 = con1.CreateCommand();
            //    cmd1.CommandType = CommandType.Text;
            //    cmd1.CommandText = "select Buyer_name from Buyer";
            //    SqlDataReader reader = cmd1.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        comboBox2.Text = reader.GetInt32(0).ToString();
            //    }
            //    reader.Close();
            //}
            //catch (Exception ex) { MessageBox.Show("" + ex); }

            

        }

        public void LoadBuyerID()
        {
            SqlConnection con1 = new SqlConnection(connection);
            //dt = new DataTable();
            string query = "select Buyer_name from Buyer";
            SqlCommand cmd = new SqlCommand(query, con1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            buyerName.DataSource = dt;
            buyerName.DisplayMember = "Buyer_name";
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 = new SqlConnection(connection);
                con1.Open();
                SqlCommand cmd1 = con1.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from Manager1 where Manager_Name like('" + metroComboBox1.SelectedItem + "')";
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    managerID.Text = reader.GetInt32(0).ToString();
                }
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }

        }

        private void buyerName_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                buyerID.Text = invoice.LoadBuyerID(buyerName.Text);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void metroBtn_Add_Click1(object sender, EventArgs e)
        {
            invoice_report_1 ir = new invoice_report_1();
            ir.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void serialInvoice_Click(object sender, EventArgs e)
        {

        }

        private void contractInvoice_Click(object sender, EventArgs e)
        {

        }

        private void statusInvoice_Click(object sender, EventArgs e)
        {

        }

        private void totAmountInvoice_Click(object sender, EventArgs e)
        {

        }

        private void totMtrInvoice_Click(object sender, EventArgs e)
        {

        }

        private void descInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}
