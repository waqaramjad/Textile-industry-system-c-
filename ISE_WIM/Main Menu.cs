using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using ISE_WIM.Transactional_Forms;
using ISE_WIM.Simple_Forms;
using ISE_WIM.Reports;


namespace ISE_WIM
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Packing_List Pl = new Packing_List();
            Pl.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Add_Manager AM = new Add_Manager();
            AM.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //Quality_wise_Item_Summary qwim = new Quality_wise_Item_Summary();
            // qwim.ShowDialog();

            Production pro = new Production();
            pro.ShowDialog();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice();
            inv.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sizing si = new Sizing();
            si.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Contract c = new Contract();
            c.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            generate_Yarn_Recipt y = new generate_Yarn_Recipt();
            y.ShowDialog();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            AddClient a = new AddClient();
            a.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Contract con = new Contract();
            con.ShowDialog();

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Manager AM = new Add_Manager();
            AM.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yarnRecieptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generate_Yarn_Recipt y = new generate_Yarn_Recipt();
            y.ShowDialog();
        }

        private void provideYarnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generate_Yarn_Recipt y = new generate_Yarn_Recipt();
            y.ShowDialog();
        }

        private void recordSizingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sizing si = new Sizing();
            si.ShowDialog();
        }

        private void productionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void packingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Packing_List Pl = new Packing_List();
            Pl.ShowDialog();
        }

        private void salesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice();
            inv.ShowDialog();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contract con = new Contract();
            con.ShowDialog();
        }

        private void clientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddClient a = new AddClient();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Packing_Report asd = new Packing_Report();
            //asd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Yarn_Recipt yr = new Yarn_Recipt();
            //yr.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}