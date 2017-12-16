using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.Sql;
using System.IO;
using System.Data.SqlClient;

namespace ISE_WIM
{
    public partial class Add_Manager : Form
    {
        string imagename;
        SqlDataAdapter empadap1;
        DataSet dset;
        string connection = @"Data Source=WAQARAMJAD;Initial Catalog=WIM;Integrated Security=True ";
        public Add_Manager()
        {
            InitializeComponent();
        }

        private void Add_Manager_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Manager1", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroBtn_manager_Add_Click(object sender, EventArgs e)
        {
            try
            {
                StoreImage();
              string insert_sqll = "INSERT INTO Manager1(Manager_Name,Manager_FatherName,Manager_CNIC,Manager_StartDate,Manager_EndDate,Manager_Contact,Manager_Email,Manager_AuthLevel,Manager_Type,Manager_Username,Manager_Password,Manager_Address,Manager_Status)VALUES('" + metroTB_Manager_Name.Text + "','" + metroTB_Manager_FName.Text + "','" + metroTB_Manager_CNIC.Text + "','" + metroDTime_Manager_Start.Value.ToShortDateString() + "','" + metroDTime_Manager_End.Value.ToShortDateString() + "','" + metroTB_Manager_Contact.Text + "','" + metroTB_Manager_Email.Text + "','" + metroTB_Manager_Auth.Text + "','" + metroTB_Manager_Type.Text + "','" + metroTB_Manager_Username.Text + "','" + metroTB_Manager_Pass.Text + "','" + richTB_manager_Address.Text + "','" + metroTB_Manager_Status.Text + "')";
                this.getcom(insert_sqll);
                MessageBox.Show("Successfully Added");

                //if (string.IsNullOrEmpty(metroTB_Manager_ID.Text))
                //{
                    //string col1 = metroGrid1[0, metroGrid1.CurrentCell.RowIndex].Value.ToString();
                    //string col2 = metroGrid1[1, metroGrid1.CurrentCell.RowIndex].Value.ToString();
                    //string col3 = metroGrid1[2, metroGrid1.CurrentCell.RowIndex].Value.ToString();
                    //string col4 = metroGrid1[3, metroGrid1.CurrentCell.RowIndex].Value.ToString();
                    //string col5 = metroGrid1[4, metroGrid1.CurrentCell.RowIndex].Value.ToString();
                    //string col6 = metroGrid1[5, metroGrid1.CurrentCell.RowIndex].Value.ToString();
                    //string col7 = metroGrid1[6, metroGrid1.CurrentCell.RowIndex].Value.ToString();
                    //string col8 = metroGrid1[7, metroGrid1.CurrentCell.RowIndex].Value.ToString();
                    //string col9 = metroGrid1[8, metroGrid1.CurrentCell.RowIndex].Value.ToString();
                    //string col10 = metroGrid1[9, metroGrid1.CurrentCell.RowIndex].Value.ToString();
                    //string col11 = metroGrid1[10, metroGrid1.CurrentCell.RowIndex].Value.ToString();
                    //string col12 = metroGrid1[11, metroGrid1.CurrentCell.RowIndex].Value.ToString();
                    //string col13 = metroGrid1[12, metroGrid1.CurrentCell.RowIndex].Value.ToString();
                    //string col14 = metroGrid1[13, metroGrid1.CurrentCell.RowIndex].Value.ToString();

                    //string insert_sql = "INSERT INTO Manager(Manager_ID,Manager_Name,Manager_FatherName,Manager_CNIC,Manager_StartDate,Manager_EndDate,Manager_Contact,Manager_Email,Manager_AuthLevel,Manager_Type,Manager_Username,Manager_Password,Manager_Address,Manager_Status)VALUES('" + col1 + "','" + col2 + "','" + col3 + "','" + col4 + "','" + col5 + "','" + col6 + "','" + col7 + "','" + col8 + "','" + col9 + "','" + col10 + "','" + col11 + "','" + col12 + "','" + col13 + "','" + col14 + "')";
                    //this.getcom(insert_sql);
                //}
            //    else
            //    {
            //    }
            }
            catch (Exception ex)
            { MessageBox.Show("Wrong transaction is being executed baby"); }
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

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                metroTB_Manager_ID.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
                metroTB_Manager_Name.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
                metroTB_Manager_FName.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
                metroTB_Manager_CNIC.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
                var vall = metroGrid1.CurrentRow.Cells[4].Value;
                metroDTime_Manager_Start.Value = Convert.ToDateTime(vall);
                var val2 = metroGrid1.CurrentRow.Cells[5].Value;
                metroDTime_Manager_End.Value = Convert.ToDateTime(val2);
                metroTB_Manager_Contact.Text = metroGrid1.CurrentRow.Cells[6].Value.ToString();
                metroTB_Manager_Email.Text = metroGrid1.CurrentRow.Cells[7].Value.ToString();
                metroTB_Manager_Auth.Text = metroGrid1.CurrentRow.Cells[8].Value.ToString();
                metroTB_Manager_Type.Text = metroGrid1.CurrentRow.Cells[9].Value.ToString();
                metroTB_Manager_Username.Text = metroGrid1.CurrentRow.Cells[10].Value.ToString();
                metroTB_Manager_Pass.Text = metroGrid1.CurrentRow.Cells[11].Value.ToString();
                richTB_manager_Address.Text = metroGrid1.CurrentRow.Cells[12].Value.ToString();
                metroTB_Manager_Status.Text = metroGrid1.CurrentRow.Cells[13].Value.ToString();

            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void metroBtn_manager_View_Click(object sender, EventArgs e)
        {
            Clear();
            Add_Manager_Load(sender,e);
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
            metroTB_Manager_Auth.Clear();
            metroTB_Manager_Type.Clear();
            metroTB_Manager_Username.Clear();
            metroTB_Manager_Pass.Clear();
            richTB_manager_Address.Clear();
            metroTB_Manager_Status.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            LoadImage();
            //StoreImage();
        }
        private void LoadImage()
        {
            FileDialog fldlg = new OpenFileDialog();

            //specify your own initial directory

            fldlg.InitialDirectory = @":D\";

            //this will allow only those file extensions to be added

            fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";

            if (fldlg.ShowDialog() == DialogResult.OK)
            {

                imagename = fldlg.FileName;

                Bitmap newimg = new Bitmap(imagename);

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox1.Image = (Image)newimg;

            }

            fldlg = null;
        }
        private void StoreImage()
        {

            //use filestream object to read the image.

            //read to the full length of image to a byte array.

            //add this byte as a parameter and insert it into database.

            try
            {

                //proceed only when the image has a valid path

                if (imagename != "")
                {

                    FileStream fs;

                    fs = new FileStream(@imagename, FileMode.Open, FileAccess.Read);

                    //a byte array to read the image

                    byte[] picbyte = new byte[fs.Length];

                    fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));

                    fs.Close();

                    //open the database using odp.net and insert the data

                    SqlConnection conn = new SqlConnection(connection);

                    conn.Open();

                    string query="";
                 //   string insert_sqll = "INSERT INTO Manager(Manager_Name,Manager_FatherName,Manager_CNIC,Manager_StartDate,Manager_EndDate,Manager_Contact,Manager_Email,Manager_AuthLevel,Manager_Type,Manager_Username,Manager_Password,Manager_Address,Manager_Status)VALUES('" + metroTB_Manager_Name.Text + "','" + metroTB_Manager_FName.Text + "','" + metroTB_Manager_CNIC.Text + "','" + metroDTime_Manager_Start.Value.ToShortDateString() + "','" + metroDTime_Manager_End.Value.ToShortDateString() + "','" + metroTB_Manager_Contact.Text + "','" + metroTB_Manager_Email.Text + "','" + metroTB_Manager_Auth.Text + "','" + metroTB_Manager_Type.Text + "','" + metroTB_Manager_Username.Text + "','" + metroTB_Manager_Pass.Text + "','" + richTB_manager_Address.Text + "','" + metroTB_Manager_Status.Text + "')";
                    query = "INSERT INTO Manager(Manager_Name,Manager_FatherName,Manager_CNIC,Manager_StartDate,Manager_EndDate,Manager_Contact,Manager_Email,Manager_AuthLevel,Manager_Type,Manager_Username,Manager_Password,Manager_Address,Manager_Status,Image)VALUES('" + metroTB_Manager_Name.Text + "','" + metroTB_Manager_FName.Text + "','" + metroTB_Manager_CNIC.Text + "','" + metroDTime_Manager_Start.Value.ToShortDateString() + "','" + metroDTime_Manager_End.Value.ToShortDateString() + "','" + metroTB_Manager_Contact.Text + "','" + metroTB_Manager_Email.Text + "','" + metroTB_Manager_Auth.Text + "','" + metroTB_Manager_Type.Text + "','" + metroTB_Manager_Username.Text + "','" + metroTB_Manager_Pass.Text + "','" + richTB_manager_Address.Text + "','" + metroTB_Manager_Status.Text + "'," + " @pic)";

                    SqlParameter picparameter = new SqlParameter();

                    picparameter.SqlDbType = SqlDbType.Image;

                    picparameter.ParameterName = "pic";

                    picparameter.Value = picbyte;

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.Add(picparameter);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("MUBARAKAN Image Added");

                    cmd.Dispose();

                    conn.Close();

                    conn.Dispose();

                    Connection();

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
        private void Connection()
        {

            //connect to the database and table

            //selecting all the columns

            //adding the name column alone to the combobox

            try
            {

                SqlConnection conn = new SqlConnection(connection);

                conn.Open();

                empadap1 = new SqlDataAdapter();

                empadap1.SelectCommand = new SqlCommand("SELECT * FROM Photo", conn);



                dset = new DataSet("dset");

                empadap1.Fill(dset);

                DataTable dtable;

                dtable = dset.Tables[0];

              //  comboBox1.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {

                   // comboBox1.Items.Add(drow[0].ToString());

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroBtn_manager_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection del = new SqlConnection(connection);
            string Query = "delete from Manager where Manager_Id='" + this.metroTB_Manager_ID.Text + "'";
            SqlCommand Delete = new SqlCommand(Query, del);
            del.Open();
            Delete.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Manager1", del);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            metroGrid1 .DataSource = ds.Tables[0].DefaultView;
            del.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroBtn_manager_Update_Click(object sender, EventArgs e)
        {

        }
    }
}
