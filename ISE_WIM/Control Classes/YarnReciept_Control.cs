using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE_WIM.Control_Classes
{
    class YarnReciept_Control
    {
        Sql_Class sql;
        string query;

        public YarnReciept_Control()
        {
            sql = new Sql_Class();
        }
        public void InsertValuse(string YR_Brand,string YR_Bags_Rcvd,string YR_Date_Rcvd,string YR_Description,string YR_Status,string YR_Count,int managerID,int contractID)
        {
            try
            {
                query = "insert into Yarn_Receipt(YR_Date,YR_Brand,YR_Bags_Recvd,YR_Date_Recvd,YR_Description,YR_Status,YR_Count,Manager_ID,Contract_ID) values (getdate(),'" + YR_Brand + "','" + YR_Bags_Rcvd + "','" + YR_Date_Rcvd + "','" + YR_Description + "','" + YR_Status + "','" + YR_Count + "'," + managerID + "," + contractID + ")";
                sql.Insert_Update_Delete(query);

            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
