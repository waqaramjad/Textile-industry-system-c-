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
    public partial class Quality_wise_Item_Summary: Form
    {
        public Quality_wise_Item_Summary()
        {
            InitializeComponent();
        }

        private void qWIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jaaBhaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice();
            inv.ShowDialog();
        }
    }
}
