using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISE_WIM.Reports
{
    public partial class production_report_viewer : Form
    {
        public production_report_viewer()
        {
            InitializeComponent();
        }

        private void production_report_viewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'production_dataset.Production_Report' table. You can move, or remove it, as needed.
            this.Production_ReportTableAdapter.Fill(this.production_dataset.Production_Report);

            this.reportViewer1.RefreshReport();
          // this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
