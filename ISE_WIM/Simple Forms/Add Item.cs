using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISE_WIM.Simple_Forms
{
    public partial class Add_Item : Form
    {
        Sql_Class sql;
        OpenFileDialog ofd;
        string fileName;
        public Add_Item()
        {
            sql = new Sql_Class();
            ofd = new OpenFileDialog();
            InitializeComponent();
        }

        private void Add_Item_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = ofd.FileName;
            string query = "insert into item_GreyCloth (IGC_brand,IGC_image) values ('"+textBox1.Text+"','"+filepath+"')";
            sql.Insert_Update_Delete(query);
        }
    }
}
