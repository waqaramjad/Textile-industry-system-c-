using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISE_WIM.Transactional_Forms;
using ISE_WIM.Simple_Forms;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.IO;


namespace ISE_WIM
{

    public partial class MENU2 : Form
    {
        string imagename;
        SqlDataAdapter empadap1;
        DataSet dset;
        string connection = @"Data Source=WAQARAMJAD;Initial Catalog=WIM;Integrated Security=True ";

        public MENU2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddClient a = new AddClient();
            a.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Add_Manager AM = new Add_Manager();
            AM.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ADD_Employ AD = new ADD_Employ();
            AD.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice();
            inv.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Production pro = new Production();
            pro.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            generate_Yarn_Recipt y = new generate_Yarn_Recipt();
            y.ShowDialog();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Contract con = new Contract();
            con.ShowDialog();
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

                empadap1.SelectCommand = new SqlCommand("SELECT * FROM Manager1", conn);



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

        private void MENU2_Load(object sender, EventArgs e)
        {
            try
            {
                Connection();
                DataTable dataTable = dset.Tables[0];

                //if there is an already an image in picturebox, then delete it

                //if (pictureBox10.Image != null)
                {

                  //  pictureBox10.Image.Dispose();

                }

                //using filestream object write the column as bytes and store it as an image

                FileStream FS1 = new FileStream("image.jpg", FileMode.Create);

                foreach (DataRow dataRow in dataTable.Rows)
                {

                    if (dataRow[0].ToString() ==103.ToString())
                    {

                        byte[] blob = (byte[])dataRow[14];

                        FS1.Write(blob, 0, blob.Length);

                        FS1.Close();

                        FS1 = null;

                        //pictureBox10.Image = Image.FromFile("image.jpg");

                        //pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;

                      //  pictureBox10.Refresh();

                    }

                }
            }
            catch (Exception ex)
            { MessageBox.Show(" " + ex.ToString()); }

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Contract con = new Contract();
            con.ShowDialog();

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            AddClient ac = new AddClient();
            ac.ShowDialog();
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            Add_Manager am = new Add_Manager();
            am.ShowDialog();
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Sizing si = new Sizing();
            si.ShowDialog();
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            generate_Yarn_Recipt gyr = new generate_Yarn_Recipt();
            gyr.ShowDialog();
        }

        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {
            Production pro = new Production();
            pro.ShowDialog();
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            Invoice inv = new Invoice();
            inv.ShowDialog();
        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            Packing_List pl = new Packing_List();
            pl.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Factories fac = new Factories();
            fac.Show();


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Packing_List pl = new Packing_List();
            pl.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            Packing_List pl = new Packing_List();
            pl.ShowDialog();
        }


    }
}
