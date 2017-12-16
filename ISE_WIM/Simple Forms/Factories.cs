using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ISE_WIM.Simple_Forms
{
    public partial class Factories : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp2\Documents\TextileManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Factories()
        {
            InitializeComponent();
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp2\Documents\TextileManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();

            String query = "INSERT INTO Factories (FactoryName,NoOFLoomz,NoOfWorkers,ManagerOfThatFactory) VALUES(" + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + ")";


            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("inserted succesfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.Open();
            String query = "SELECT * FROM Factories";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);

            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void Factories_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }
    }
}
