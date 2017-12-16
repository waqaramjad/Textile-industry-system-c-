using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ISE_WIM.Control_Classes
{
    class Delivery_Order
    {
        Sql_Class sql;
        string query;

        public Delivery_Order()
        {
            sql = new Sql_Class();
        }
        public void InsertValuse(string Challan_Brand, string Challan_Quality, string Challan_Status, string Challan_Date, string Challan_Quantity, string Challan_Description, int managerID, int contractID)
        {
            try
            {
            
             //   query = "insert into values ('"+ Challan_Date + "','" + Challan_Quality + "','" + Challan_Brand + "','" + Challan_Quantity + "','" +  managerID + "')";
               // sql.Insert_Update_Delete(query);
            MessageBox.Show("Added Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong transaction");
            }
        }
    }
}
