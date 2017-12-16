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
using ISE_WIM.Control_Classes;

namespace ISE_WIM.Transactional_Forms
{
    public partial class generate_Yarn_Recipt : Form
    {
        YarnReciept_Control asd;
        Delivery_Order abc;
        string connection = @"Data Source=WAQARAMJAD;Initial Catalog=WIM;Integrated Security=True ";
        private object metroTB_Quality;

        public generate_Yarn_Recipt()
        {
            asd = new YarnReciept_Control();
            abc = new Delivery_Order();
            InitializeComponent();
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

        public void loadyarnwala()
        {

            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Yarn_Receipt", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0].DefaultView;
            con.Close();

        }

        public void loadchallanwala()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from [Challan_D/O]", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            metroGrid2.DataSource = ds.Tables[0].DefaultView;
            con.Close();

        }

        private void generate_Yarn_Recipt_Load(object sender, EventArgs e)
        {

            loadchallanwala();
            loadyarnwala();

            LoadContract_ID();

            SqlConnection CustomerName = new SqlConnection(connection);
            {
                CustomerName.Open();

                string q = "SELECT Manager_Name FROM Manager1";
                SqlCommand cmdd = new SqlCommand(q, CustomerName);
                SqlDataReader Reader = cmdd.ExecuteReader();
                while (Reader.Read())
                {
                    metroComboBox2.Items.Add(Reader["Manager_Name"]);

                }
                CustomerName.Close();


                SqlConnection CustomerName1 = new SqlConnection(connection);
                {
                    CustomerName1.Open();

                    string q1 = "SELECT Client_Name FROM Client1";
                    SqlCommand cmdd1 = new SqlCommand(q1, CustomerName1);
                    SqlDataReader Reader1 = cmdd1.ExecuteReader();
                    while (Reader1.Read())
                    {
                        metroComboBox1.Items.Add(Reader1["Client_Name"]);

                    }
                    CustomerName1.Close();
                }
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 = new SqlConnection(connection);
                con1.Open();
                SqlCommand cmd1 = con1.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from Client1 where Client_Name like('" + metroComboBox1.SelectedItem + "')";
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    clientID.Text = reader.GetInt32(0).ToString();
                }
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 = new SqlConnection(connection);
                con1.Open();
                SqlCommand cmd1 = con1.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from Manager1 where Manager_Name like('" + metroComboBox2.SelectedItem + "')";
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    managerID.Text = reader.GetInt32(0).ToString();
                }
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void doSavebtn_Click(object sender, EventArgs e)
        {

            //c.InsertValuse(do_Brandtxt.Text, do_qualitytxt.Text, do_Statustxt.Text, do_Datetp.Text, do_Quantitytxt.Text, do_Descrptxt.Text, Int32.Parse(managerID.Text), Int32.Parse(contractID.Text));
                string insert_sqll = "insert into Challan_D/O (Challan_Date,Challan_Quality,Challan_Brand,Challan_Quantity,Challan_Status,C_ID,M_ID)VALUES('"+ do_Datetp.Text + "','"+ do_qualitytxt.Text + "','"+ do_Brandtxt.Text + "','" + do_Quantitytxt.Text + "','"+ do_Statustxt.Text + "','"+ Int32.Parse(contractID.Text) + "','"+ Int32.Parse(managerID.Text) + "') ";
         //   string insert_sqll = "INSERT INTO contract1(Contract_month_start,Contract_month_end,Contract_payment_term,Contract_Delievery_term,Contract_loom_size,Contract_no_of_looms,Contract_item_name,Contract_description,Contract_Rate_per_Mtr,Contract_Total_cost,M_ID,contract_Remarks)VALUES('" + startDate.Text + "','" + endDate.Text + "','" + cPaymenttermtxt.Text + "','" + cDeliverytermtxt.Text + "','" + LoomSize.Text + "','" + NoOfLommstxt.Text + "','" + ItemNametxt.Text + "','" + cDescrtxt.Text + "','" + ratemtrtxt.Text + "','" + TotalCosttxt.Text + "','" + metroTextBox1.Text + "','" + ItmDSCP.Text + "')";


            this.getcom(insert_sqll);

          //  abc.InsertValuse();
        }

        private void dodeletebtn_Click(object sender, EventArgs e)
        {

        }
        
        private void doUpdatebtn_Click(object sender, EventArgs e)
        {

        }

        private void doNewbtn_Click(object sender, EventArgs e)
        {
            generate_Yarn_Recipt_Load(sender, e);
        }

        private void gyr_Savebtn_Click(object sender, EventArgs e)
        {
            try
            {

                // asd.InsertValuse(y_Brandtxt.Text, bagReceived.Text, yrDateRcvd.Text, do_Descrptxt.Text, yStatustxt.Text, yR_COunt.Text, Int32.Parse(managerID.Text), Int32.Parse(contractID.Text));
                //   abc.InsertValuse( do_Brandtxt.Text, do_qualitytxt.Text, do_Statustxt.Text, do_Datetp.Text, do_Quantitytxt.Text, do_Descrptxt.Text,Int32.Parse(managerID.Text), Int32.Parse(contractID.Text));
                // true     string insert_sqll = "insert into Yarn_Receipt(YR_Brand,YR_Count,YR_Bags_Recvd,YR_Description,M_ID,YR_Status)values ( '"+y_Brandtxt.Text+"', '"+yR_COunt.Text+"', '"+y_Desctxt.Text+"', '"+ y_Brandtxt.Text+ "' , '" + Int32.Parse(managerID.Text) + "' , '" + yStatustxt.Text+"')";
                // false string insert_sqll = "insert into Yarn_Receipt(YR_Date,YR_Brand,YR_Count,YR_Bags_Recvd,YR_Date_Recvd,YR_Description,M_ID,YR_Status)values ('" + yrDatestart.Value.ToShortDateString()+"', '"+y_Brandtxt.Text+"', '"+yR_COunt.Text+"', '"+ yrDatestart.Value.ToShortDateString()+"', '"+y_Desctxt.Text+"', '"+ y_Brandtxt.Text+ "' , '" + managerID.Text + "' , '" + yStatustxt.Text+"')";
                //  string insert_sqll = "insert into Yarn_Receipt(YR_Date,YR_Brand,YR_Count,YR_Bags_Recvd,YR_Date_Recvd,YR_Description,M_ID,YR_Status)values ('" + yrDatestart.Text+"', '"+y_Brandtxt.Text+"', '"+yR_COunt.Text+"', '"+ yrDatestart.Text+"', '"+ y_Brandtxt.Text + "', '"+ y_Desctxt.Text + "' , '" + Int32.Parse(managerID.Text) + "' , '" + yStatustxt.Text+"')";
                string insert_sqll = "insert into Yarn_Receipt(YR_Date,YR_Brand,YR_Count,YR_Bags_Recvd,YR_Date_Recvd,YR_Description,M_ID,YR_Status) values('" + yrDatestart.Text+"', '"+y_Brandtxt.Text+"', '"+yR_COunt.Text+"', '"+yR_COunt.Text+"', '"+ yrDatestart.Text+"', '"+ y_Desctxt.Text + "', '" + Int32.Parse(managerID.Text) + "', '" + yStatustxt.Text+"')";
                this.getcom(insert_sqll);
                MessageBox.Show("Successfully Added");

               // string insert_sqll = "INSERT INTO Manager1(Manager_ID,Manager_Name,Manager_FatherName,Manager_CNIC,Manager_Type,Manager_Username,Manager_Password,Manager_Address,Manager_Status)VALUES('" + metroTB_Manager_ID.Text + "','" + metroTB_Manager_Name.Text + "','" + metroTB_Manager_FName.Text + "','" + metroTB_Manager_CNIC.Text + "','" + metroDTime_Manager_Start.Value.ToShortDateString() + "','" + metroDTime_Manager_End.Value.ToShortDateString() + "','" + metroTB_Manager_Contact.Text + "','" + metroTB_Manager_Email.Text + "','" + metroTB_Manager_Auth.Text + "','" + metroTB_Manager_Type.Text + "','" + metroTB_Manager_Username.Text + "','" + metroTB_Manager_Pass.Text + "','" + richTB_manager_Address.Text + "','" + metroTB_Manager_Status.Text + "')";
                //string insert_sqll = "INSERT INTO Yarn_Recipt(YR_Date,YR_Brand,YR_Count,YR_Bags_Recvd,YR_DO_No,YR_Date_Recvd,YR_Description,YR_Status,Contract_PO_nmbr)VALUES('" + metroDateTime1.Value.ToShortDateString()+ y_Brandtxt.Text + "','" + yBagsRcvdtxt.Text + "','"  + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroComboBox3.Text + "','" + metroTextBox1.Text + "','" +do_qualitytxt + "','", metroDateTime2 + "','",+y_Desctxt.Text + "','",yStatustxt+ + metroComboBox2.Text + "')";
                //this.getcom(insert_sqll);
                //MessageBox.Show("Successfully Added");

            }


            catch (Exception ex)
            {
                MessageBox.Show("Wrong transaction is being executed"+ex);
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

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void y_Desctxt_Click(object sender, EventArgs e)
        {

        }

      

        private void yBagsRcvdtxt_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == metroGrid1.Columns["ID"].Index)
            {
                string id = Convert.ToString(metroGrid1.Rows[e.RowIndex].Cells["ID"].Value);
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from [Challan_D/O] where YR_ID = '"+ id +"'" ,con);
                DataTable T = new DataTable();
                sda.Fill(T);
                metroGrid2.AutoGenerateColumns = true;
                metroGrid2.DataSource = T;
                con.Close();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gyr_newbtn_Click(object sender, EventArgs e)
        {
            generate_Yarn_Recipt_Load(sender, e);
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yrDatestart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void managerID_Click(object sender, EventArgs e)
        {

        }

        private void do_Brandtxt_Click(object sender, EventArgs e)
        {

        }

        private void do_qualitytxt_Click(object sender, EventArgs e)
        {

        }

        private void do_Statustxt_Click(object sender, EventArgs e)
        {

        }

        private void do_Datetp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void do_Quantitytxt_Click(object sender, EventArgs e)
        {

        }

        private void do_Descrptxt_Click(object sender, EventArgs e)
        {

        }

        private void do_Id_Click(object sender, EventArgs e)
        {

        }

        private void clientID_Click(object sender, EventArgs e)
        {

        }
    }
}


