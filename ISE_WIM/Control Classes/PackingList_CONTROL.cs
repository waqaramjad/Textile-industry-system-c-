using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE_WIM.Control_Classes
{
    class PackingList_CONTROL
    {
        Sql_Class sql;
        DataTable dt;
        string query;

        public PackingList_CONTROL()
        {
            sql = new Sql_Class();
        }

        public DataTable LoadItemName()
        {
            try
            {
                query = "select IGC_Brand from Item_GreyCloth";
                dt = new DataTable();
                dt = sql.Search(query);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
        public void InsertValue(string PL_Date,string PL_Party,string PL_Quality,string  PL_Total_Mtr, string PL_TotalPeice, string PL_Vehicle_no, string PL_Status, string Manager_ID, string Contract_ID)
        {
            try
            {
                query = "insert into PackingList ([PL_Date],[PL_Party],[PL_Quality],[PL_Total_Mtr],[PL_TotalPeice],[PL_Vehicle_no],[PL_Status],[Manager_ID],[Contract_ID]) values " +
                                                "(" + PL_Date + ",'" + PL_Party + "','" + PL_Quality + "'," + PL_Total_Mtr + "," + PL_TotalPeice + ",'" + PL_Vehicle_no + "','" + PL_Status + "'," + Manager_ID + "," + Contract_ID + ")";
                sql.Insert_Update_Delete(query);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
