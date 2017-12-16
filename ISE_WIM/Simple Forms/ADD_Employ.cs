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
    public partial class ADD_Employ : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp2\Documents\TextileManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public ADD_Employ()
        {
            InitializeComponent();
        }

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ADD_Employ_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd.CommandText = "insert into Employs(id,Name,FatherName,WorkType,FactoryAssign,Experience,CNIC,Adress) values('" + textBox8.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Clone();
            cn.Close();
            MessageBox.Show("data added ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cn.Open();
            String query = "SELECT * FROM Employs";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);

            dataGridView1.DataSource = dt;
            cn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            cn.Open();
            String query = "SELECT * FROM Employs";
            SqlDataAdapter SDA = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);

            dataGridView1.DataSource = dt;
            cn.Close();
        }
    }
}
