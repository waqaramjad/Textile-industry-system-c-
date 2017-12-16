using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISE_WIM.Control_Classes
{
    class Contract_Control
    {
        Sql_Class sql;
        string query;

        public Contract_Control()
        {
            sql = new Sql_Class();
        }
        public void InsertValuse(string Contract_month_start,string Contract_month_end,string Contract_payment_term,string Contract_Delievery_term,string Contract_loom_size,string Contract_no_of_looms,string Contract_item_name,string Contract_description,string Contract_Rate_per_Mt,string Contract_Total_cost,string Contract_Remarks)
        {
            try
            {
                query = "insert into Contract1([Contract_month_start],[Contract_month_end],[Contract_payment_term],[Contract_Delievery_term],[Contract_loom_size],[Contract_no_of_looms],[Contract_item_name],[Contract_description],[Contract_Rate_per_Mtr],[Contract_Total_cost],[Contract_Remarks]) values('"+Contract_month_start+"','"+Contract_month_end+"','"+Contract_payment_term+"','"+Contract_Delievery_term+"','"+Contract_loom_size+"',"+Contract_no_of_looms+",'"+Contract_item_name+"','"+Contract_description+"',"+Contract_Rate_per_Mt+","+Contract_Total_cost+",'"+Contract_Remarks+"')";
                sql.Insert_Update_Delete(query);
               MessageBox.Show("Added Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong transaction");
            }
        }

        public DataTable SearchValue()
        {
            try
            {
                query = " select [Contract_month_start],[Contract_month_end],[Contract_payment_term],[Contract_Delievery_term],[Contract_loom_size],[Contract_no_of_looms],[Contract_item_name],[Contract_description],[Contract_Rate_per_Mtr],[Contract_Total_cost],[Contract_Remarks] from Contract1";
                DataTable dt = new DataTable();
                dt = sql.Search(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable LoadContract()
        {
            try
            {
                query = "select Contract_ID from Contract1";
                DataTable dt = new DataTable();
                dt = sql.Search(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void DeleteValues(string contractID)
        {
            try
            {
                query = "delete Contract1 where Contract_ID = "+contractID+"";
                sql.Insert_Update_Delete(query);
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}
