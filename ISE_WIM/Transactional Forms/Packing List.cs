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
using ISE_WIM.Simple_Forms;

namespace ISE_WIM
{
    public partial class Packing_List : Form
    {
        PackingList_CONTROL plc;
        string connection = @"Data Source=WAQARAMJAD;Initial Catalog=WIM;Integrated Security=True ";
        public Packing_List()
        {
            plc = new PackingList_CONTROL();
            InitializeComponent();
        }

        private void Packing_List_Load(object sender, EventArgs e)
        {
            LoadDGVItems();
            LoadPONumber();

            try
            {
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from PackingList", con);
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

        private void metroLabel6_Click(object sender, EventArgs e)
        {

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
                        managerID.Text = reader.GetInt32(0).ToString();
                    }
                    reader.Close();
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void metroBtn_Add_Click(object sender, EventArgs e)
        {
            try
            {

               // string insert_sqll = "INSERT INTO PackingList(PL_Date,PL_Party,PL_Quality,PL_Total_Mtr,PL_TotalPeice,PL_Vehicle_no,PL_Status,Contract_ID,Manager_ID)VALUES('" + metroDateTime_PL.Value.ToShortDateString() + "','" + metroTextBox3.Text + "','" + metroTB_Quality.Text + "','" + metroTB_TotalMeter.Text + "','" + metroTextBox1.Text + "','" + metroTB_Vehicle.Text + "','" + metroTB_Status.Text + "','"+metroComboBox2.SelectedIndex.ToString()+"','"+metroComboBox1.SelectedIndex.ToString()+"')";
                string insert_sqll = "INSERT INTO PackingList(PL_Date,PL_Party,PL_Quality,PL_Total_Mtr,PL_TotalPeice,PL_Vehicle_no,M_ID,PL_Status)VALUES('" + metroDateTime_PL.Value.ToShortDateString()+ "','" + partyPL.Text + "','" + qualityPL.Text + "','" + totMtrTxt .Text+ "','" + totPeiceTxt.Text + "','" + vehicleNo.Text + "','" + managerID.Text + "','"+ statusTxt.Text +"')";
                this.getcom(insert_sqll);
             //   plc.InsertValue(metroDateTime_PL.Text, partyPL.Text, qualityPL.Text, totMtrTxt.Text, totPeiceTxt.Text, vehicleNo.Text, statusTxt.Text, managerID.Text, contractID.Text);

                MessageBox.Show("Successfully Added");

                //if (string.IsNullOrEmpty(metroTB_PL_ID.Text))
                //{
                //    string col1 = metroGrid_PLLI[0, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();
                //    string col2 = metroGrid_PLLI[1, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();
                //    string col3 = metroGrid_PLLI[2, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();
                //    string col4 = metroGrid_PLLI[3, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();
                //    string col5 = metroGrid_PLLI[4, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();
                //    string col6 = metroGrid_PLLI[5, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();
                //    string col7 = metroGrid_PLLI[6, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();
                //    string col8 = metroGrid_PLLI[7, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();
                //    string col9 = metroGrid_PLLI[8, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();
                //    string col10 = metroGrid_PLLI[9, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();
                //    string col11 = metroGrid_PLLI[10, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();
                //    //string col12 = metroGrid_PLLI[11, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();
                //    //string col13 = metroGrid_PLLI[12, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();
                //    //string col14 = metroGrid_PLLI[13, metroGrid_PLLI.CurrentCell.RowIndex].Value.ToString();

                //    string insert_sql = "INSERT INTO PackingList(PL_ID,PLI_ID,PL_Date,PL_Date,PL_Party,PL_Quality,PL_Total_Mtr,PL_TotalPeice,PL_Vehicle_no,PL_Status)VALUES('" + col1 + "','" + col2 + "','" + col3 + "','" + col4 + "','" + col5 + "','" + col6 + "','" + col7 + "','" + col8 + "','" + col9 + "','" + col10 + "','" + col11 + "')";
                //    this.getcom(insert_sql);
                //}
                //else
                //{
                //    //string insert_sqll = "INSERT INTO Manager(Manager_ID,Manager_Name,Manager_FatherName,Manager_CNIC,Manager_Type,Manager_Username,Manager_Password,Manager_Address,Manager_Status)VALUES('" + metroTB_Manager_ID.Text + "','" + metroTB_Manager_Name.Text + "','" + metroTB_Manager_FName.Text + "','" + metroTB_Manager_CNIC.Text + "','" + metroDTime_Manager_Start.Value.ToShortDateString() + "','" + metroDTime_Manager_End.Value.ToShortDateString() + "','" + metroTB_Manager_Contact.Text + "','" + metroTB_Manager_Email.Text + "','" + metroTB_Manager_Auth.Text + "','" + metroTB_Manager_Type.Text + "','" + metroTB_Manager_Username.Text + "','" + metroTB_Manager_Pass.Text + "','" + richTB_manager_Address.Text + "','" + metroTB_Manager_Status.Text + "')";
                //    string insert_sqll = "INSERT INTO PackingList(PL_ID,PL_Date,PL_Date,PL_Party,PL_Quality,PL_Total_Mtr,PL_TotalPeice,PL_Vehicle_no,PL_Status)VALUES('" + metroTB_PL_ID.Text + "','" + metroDateTime_PL.Value.ToShortDateString() + "','" + metroTextBox3.Text + "','" + metroTB_Quality.Text + "','" + metroTB_TotalMeter.Text + "','" + metroTextBox1.Text + "','" + metroTB_Vehicle.Text + "','" + metroTB_Status.Text + "')";
                //    this.getcom(insert_sqll);
                //    MessageBox.Show("Successfully Added");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong transaction is being executed");
            }
        }

        public void LoadDGVItems()
        {
            DataTable dt = new DataTable();
            dt = plc.LoadItemName();
            ItemNameGrid.Items.Clear();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ItemNameGrid.Items.Add(dt.Rows[i][0].ToString());
                }
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

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroBtn_View_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            String query = "SELECT * FROM PackingList";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);

            metroGrid_PLLI.DataSource = dt;
            con.Close();
            Clear();
            Packing_List_Load(sender, e);
        }

        public void Clear()
        {
            metroTB_PL_ID.Clear();
            qualityPL.Clear();
          //  metroTB_Contract.Clear();
            partyPL.Clear();
            metroDateTime_PL.ResetText();
            //metroDTime_Manager_End.ResetText();
            vehicleNo.Clear();
            statusTxt.Clear();
            totMtrTxt.Clear();
            totPeiceTxt.Clear();
            //metroTB_Manager_Username.Clear();
            //metroTB_Manager_Pass.Clear();
            //richTB_manager_Address.Clear();
            //metroTB_Manager_Status.Clear();
        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {
          

        }

        public void LoadPONumber()
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

        private void metroLabel12_Click_1(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            SqlConnection con = new SqlConnection(connection);
            for (int i = 0; i < metroGrid_PLLI.Rows.Count - 1; i++)
            {
                try
                {

                    con.Open();
                    var v = metroGrid_PLLI.Rows[i].Cells[0].Value;
                    string d = "Select IGC_Image from item_greycloth where IGC_brand ='" + v.ToString() + "'";
                    SqlCommand cmdd = new SqlCommand(d,con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmdd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    //pictureBox1.ImageLocation = dt.Rows[0][0].ToString();

                    con.Close();
                }
                catch (Exception)
                {


                }


                // string d = "SELECT item_Image from Item"

                    }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtnForGrid_Click(object sender, EventArgs e)
        {
            double qtyTot = 0;
            for (int i = 0; i < itemGrid.Rows.Count-1; i++)
            {
                string qtyString = itemGrid.Rows[i].Cells[1].Value.ToString();
                double qtyDouble = Double.Parse(qtyString);
                qtyTot += qtyDouble;
            }
            totQtyforGrid.Text = qtyTot.ToString();
        }

        private void AddBtnForGrid_Click123(object sender, EventArgs e)
        {
            Add_Item ai = new Add_Item();
            ai.ShowDialog();
        }

        private void metroGrid_PLLI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void managerID_Click(object sender, EventArgs e)
        {

        }

        private void metroTB_PL_ID_Click(object sender, EventArgs e)
        {

        }

        private void vehicleNo_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime_PL_ValueChanged(object sender, EventArgs e)
        {

        }

        private void statusTxt_Click(object sender, EventArgs e)
        {

        }

        private void totMtrTxt_Click(object sender, EventArgs e)
        {

        }

        private void totPeiceTxt_Click(object sender, EventArgs e)
        {

        }

        private void partyPL_Click(object sender, EventArgs e)
        {

        }

        private void qualityPL_Click(object sender, EventArgs e)
        {

        }
    }
}

