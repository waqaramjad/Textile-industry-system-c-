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
    public partial class Invoice_Report : Form
    {
        public Invoice_Report()
        {
            InitializeComponent();
        }

        private void Invoice_Report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
