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
using ISE_WIM.Control_Classes;

namespace ISE_WIM.Transactional_Forms
{
    public partial class Contract : Form
    {
        string connection = @"Data Source=WAQARAMJAD;Initial Catalog=WIM;Integrated Security=True ";
        Contract_Control cc;
        public Contract()
        {
            cc = new Contract_Control();
            InitializeComponent();
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            try
            {
                contractGridView.DataSource = cc.SearchValue();
                DataTable dt = new DataTable();
                dt = cc.LoadContract();
                contractID.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    contractID.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
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
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {


                // string insert_sqll = "INSERT INTO contract1(Contract_month_start,Contract_payment_term,Contract_Delievery_term,Contract_loom_size,Contract_no_of_looms,Contract_item_name,Contract_description,Contract_Rate_per_Mtr,Contract_Total_cost,Contract_PO_nmbr,Manager_ID,Contract_item_descrp,Contract_No_bags,Contract_Quantity,Contract_EndDate)VALUES('" + metroDateTime1.Value.ToShortDateString() + "','" + cPaymenttermtxt.Text + "','" + cDeliverytermtxt.Text + "','" + LoomSize.Text + "','" + NoOfLommstxt.Text + "','" + ItemNametxt.Text + "','" + cDescrtxt.Text + "','" + ratemtrtxt.Text + "','" + TotalCosttxt.Text + "','" + metroTextBox1.Text + "','" + metroTextBox3.Text + "','" + ItmDSCP.Text + "','" + NoOfBagstxt.Text + "','"+cQuantitytxt.Text+"','"+ metroDateTime2.Value.ToShortDateString() +"')";
                string insert_sqll = "INSERT INTO contract1(Contract_month_start,Contract_month_end,Contract_payment_term,Contract_Delievery_term,Contract_loom_size,Contract_no_of_looms,Contract_item_name,Contract_description,Contract_Rate_per_Mtr,Contract_Total_cost,M_ID,contract_Remarks)VALUES('" + startDate.Text+ "','" + endDate.Text +"','"+cPaymenttermtxt.Text + "','" + cDeliverytermtxt.Text + "','" + LoomSize.Text + "','" + NoOfLommstxt.Text + "','" + ItemNametxt.Text + "','" + cDescrtxt.Text + "','" + ratemtrtxt.Text + "','" + TotalCosttxt.Text + "','" + metroTextBox1.Text + "','" + ItmDSCP.Text +"')";

                this.getcom(insert_sqll);
             //   cc.InsertValuse(startDate.Text, endDate.Text, cPaymenttermtxt.Text, cDeliverytermtxt.Text, LoomSize.Text, NoOfLommstxt.Text, ItemNametxt.Text, cDescrtxt.Text, ratemtrtxt.Text, TotalCosttxt.Text, ratemtrtxt.Text); 
                    MessageBox.Show("Successfully Added");
                
            }
            catch (Exception ex)
            { MessageBox.Show("Wrong transaction is being executed \n"+ex.Message,Application.ProductName); }
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

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                    metroTextBox3.Text = reader.GetInt32(0).ToString();
                }
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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
                    metroTextBox3.Text = reader.GetInt32(0).ToString();
                }
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            Contract_Load(sender, e);

            try
            {
                contractGridView.DataSource = cc.SearchValue();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (contractID.Text != "")
            {
                string topi = "Warning!";
                if (MessageBox.Show("Are you sure?",topi,MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    cc.DeleteValues(contractID.Text);
                }
                
                
            }
            
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(metroTextBox1, "Numbers Only");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(metroTextBox1.Text, "  ^ [0-9]"))
            {
                metroTextBox1.Text = "";
            }

        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cPaymenttermtxt_Click(object sender, EventArgs e)
        {

        }

        private void contractID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cDescrtxt_Click(object sender, EventArgs e)
        {

        }

        private void cDeliverytermtxt_Click(object sender, EventArgs e)
        {

        }

        private void ItmDSCP_Click(object sender, EventArgs e)
        {

        }

        private void LoomSize_Click(object sender, EventArgs e)
        {

        }

        private void ItemNametxt_Click(object sender, EventArgs e)
        {

        }

        private void ratemtrtxt_Click(object sender, EventArgs e)
        {

        }

        private void TotalCosttxt_Click(object sender, EventArgs e)
        {

        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }
