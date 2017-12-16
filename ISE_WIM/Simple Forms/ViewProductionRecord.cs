using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISE_WIM.Simple_Forms
{
    public partial class ViewProductionRecord : Form
    {

        string connection = @"Data Source=WAQARAMJAD;Initial Catalog=WIM;Integrated Security=True ";

        public ViewProductionRecord()
        {
            InitializeComponent();
        }

        private void ViewProductionRecord_Load(object sender, EventArgs e)
        {
            loadProductionReport();
            loadProductionReportLI();
        }

        public void loadProductionReport()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Production_Report", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0].DefaultView;
            con.Close();

        }

        public void loadProductionReportLI()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from ProductionReport_Lineitem", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            metroGrid2.DataSource = ds.Tables[0].DefaultView;
            con.Close();

        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
