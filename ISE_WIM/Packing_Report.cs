using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISE_WIM
{
    public partial class Packing_Report : Form
    {
        public Packing_Report()
        {
            InitializeComponent();
        }

        private void Packing_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.PackingList' table. You can move, or remove it, as needed.
            this.PackingListTableAdapter.Fill(this.DataSet1.PackingList);

            this.reportViewer1.RefreshReport();
        }
    }
}
