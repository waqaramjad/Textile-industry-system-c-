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
    public partial class invoice_report_1 : Form
    {
        public invoice_report_1()
        {
            InitializeComponent();
        }

        private void invoice_report_1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invoice.Invoice' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                this.InvoiceTableAdapter.Fill(this.invoice.Invoice, Convert.ToInt32(textBox1.Text));

                this.reportViewer1.RefreshReport();

            }
            else
            {
                MessageBox.Show("Enter ID");
            }

        }
    }
}
