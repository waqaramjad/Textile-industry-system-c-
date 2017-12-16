using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ISE_WIM
{
    class Sql_Class
    {
        string Connection_String;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        DataTable dt;

        public Sql_Class()
        {
            Connection_String = @"Data Source=WAQARAMJAD;Initial Catalog=WIM;Integrated Security=True ";
            cmd = null;
            sda = null;
            dt = null;
            con = new SqlConnection(Connection_String);
        }
        public Sql_Class(string connectionstring)
        {
            Connection_String = connectionstring;
            cmd = null;
            sda = null;
            dt = null;
            con = new SqlConnection(Connection_String);
        }
        public bool Insert_Update_Delete(string query)
        {
            bool d = false;
            try
            {
                cmd = new SqlCommand(query, con);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    d = true;
                }
                con.Close();
                return d;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return d;
            }
        }
        public DataTable Search(string query)
        {
            try
            {
                cmd = new SqlCommand(query, con);
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        public int Count_No_of_Rows(string query)
        {
            try
            {
                cmd = new SqlCommand(query, con);
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                return dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }
    }
}
