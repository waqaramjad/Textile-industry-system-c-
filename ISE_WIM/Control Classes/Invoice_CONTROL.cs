using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE_WIM.Control_Classes
{
    class Invoice_CONTROL
    {
        Sql_Class sql;
        DataTable dt;
        string query;

        public Invoice_CONTROL()
        {
            sql = new Sql_Class();
        }

        public void InsertValues(string I_Date,string I_Serial_No, string I_total_Amount, string I_Contract_No, string I_Description, string Manager_ID,string I_Status,string I_TotalMeter,string Buyer_ID, string Contract_ID)
        {
            try
            {
                query = "insert into Invoice ([I_Date],[I_Serial_No],[I_total_Amount],[I_Contract_No],[I_Description],[Manager_ID],[I_Status],[I_TotalMeter],[Buyer_ID],[Contract_ID])" +
                    "values ('" + I_Date + "','" + I_Serial_No + "'," + I_total_Amount + ",'" + I_Contract_No + "','" + I_Description + "'," + Manager_ID + ",'" + I_Status + "'," + I_TotalMeter + "," + Buyer_ID + "," + Contract_ID + ")";
                sql.Insert_Update_Delete(query);
            }
            catch (Exception ex)
            {
                
            }
        }

        public string LoadBuyerID(string buyerName)
        {
            try
            {
                query = "select Buyer_ID from Buyer where Buyer_Name = '" + buyerName + "'";
                dt = new DataTable();
                dt = sql.Search(query);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0][0].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
